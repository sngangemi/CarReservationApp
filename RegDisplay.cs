using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservation
{
    public partial class RegDisplay : Form
    {
        private Label titleLabel;
        public List<Car> _Cars;
        public CarRegistry _registry;
        List<CarRegistry> _registries;
        int _index;

        //Initialization
        public RegDisplay(List<CarRegistry> registries, int index)
        {
            InitializeComponent();
            //Create Title
            titleLabel = new Label();
            titleLabel.Text = registries[index].Name;
            titleLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Location = new Point((this.ClientSize.Width - titleLabel.Width) / 2, 10);
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(titleLabel);

            //this is passed by reference
            _registry = registries[index];
            _Cars = _registry.Cars;
            _registries = registries;
            _index = index;

            
        }

        //Load Display using car list
        private void RegDisplay_Load(object sender, EventArgs e)
        {
            // Populate the ListBox with the cars
            CarList.Items.Clear(); // Clear the list box before populating
            foreach (var car in _Cars)
            {
                Console.WriteLine(car.Type.ToString()+": "+car.LicensePlate);
                CarList.Items.Add(car.Type.ToString() + ": " + car.LicensePlate); // Add each cars's name
            }
        }


        //Create new car
        private void newCarButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(typeBox.Text,out int result)){

                if (result < 0 || result > 2)
                {
                    MessageBox.Show("Car Type must be either 0, 1, or 2 corresponding to Sedan, Suv, and Van respectively", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //checks if licenseplate input box is greater than 3 char
                    if (plateBox.Text.Length <= 3)
                    {
                        MessageBox.Show("License Plates must be greater than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Car.CarType carType = (Car.CarType)result;
                        Car newCar = new Car(carType, plateBox.Text.ToUpper());
                        _registry.AddCar(newCar);
                        RegDisplay_Load(null, null);
                    }
                }

            }
            else
            {
                MessageBox.Show("Car type must be an integer: 0,1 or 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //Select car to delete or delete/edit reservation times 
        private void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CarList.SelectedIndex;
            if (selectedIndex >= 0)
            {
                CarDisplay carDisplay = new CarDisplay(_registries,_index, selectedIndex);
                carDisplay.ShowDialog();
                RegDisplay_Load(null, null);
            }
        }

        //Delete current registry and close window
        private void registryDeleteButton_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this registry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Remove the car from the _Cars list
                _registries.RemoveAt(_index);



                this.Close();
            }
        }
    }
}
