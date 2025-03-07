using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservation
{
    public partial class CarDisplay : Form
    {
        private Label carTitleLabel;
        public List<Car> _Cars;
        List<CarRegistry> _registries;
        int _rIndex;
        int _cIndex;
        Car _Car;

       //Initialize
        public CarDisplay(List<CarRegistry> registries, int rIndex, int cIndex)
        {
            _registries = registries;
            _Cars = registries[rIndex].Cars;
            _cIndex = cIndex;
            _rIndex = rIndex;
            _Car = _Cars[cIndex];


            InitializeComponent();


            //Makes title
            carTitleLabel = new Label();
            carTitleLabel.Text = _Car.Type.ToString() + ": " + _Car.LicensePlate;
            carTitleLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            carTitleLabel.AutoSize = true;
            carTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            carTitleLabel.Location = new Point((this.ClientSize.Width - carTitleLabel.Width) / 2, 10);
            carTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(carTitleLabel);
        }

        //Load display using car reservation data
        private void CarDisplay_Load(object sender, EventArgs e)
        {
            // Populate the ListBox with the dates
            dateList.Items.Clear(); // Clear the list box before populating
            foreach (var dateTuple in _Car.UsageTimes)
            {

                dateList.Items.Add(dateTuple.Item1.ToString() + "---" + dateTuple.Item2.ToString()); // Add each date range
            }
        }

    
        //Checks if start and end dates are valid and then adds reservation if so
        private void carReserveButton_Click(object sender, EventArgs e)
        {
            bool validInput = true;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MaxValue;

            //Checks if start date given is a valid date
            if (int.TryParse(startDayBox.Text, out int startDay))
            {
                if (int.TryParse(startMonthBox.Text, out int startMonth))
                {
                    if (int.TryParse(startYearBox.Text, out int startYear))
                    {
                        try
                        {
                            startDate = new DateTime(startYear, startMonth, startDay);
                        }
                        catch
                        {
                            MessageBox.Show("Invalid Start Date Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validInput = false;
                        }

                    }
                    else
                    {
                        validInput = false;
                        MessageBox.Show("Invalid Start Year Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    validInput = false;
                    MessageBox.Show("Invalid Start Month Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                validInput = false;
                MessageBox.Show("Invalid Start Day Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ////Checks if end date given is a valid date
            if (validInput)
            {
                if (int.TryParse(endDayBox.Text, out int endDay))
                {
                    if (int.TryParse(endMonthBox.Text, out int endMonth))
                    {
                        if (int.TryParse(endYearBox.Text, out int endYear))
                        {
                            try
                            {
                                endDate = new DateTime(endYear, endMonth, endDay);
                            }
                            catch
                            {
                                MessageBox.Show("Invalid End Date Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validInput = false;
                            }

                        }
                        else
                        {
                            validInput = false;
                            MessageBox.Show("Invalid Start Year Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        validInput = false;
                        MessageBox.Show("Invalid Start Month Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    validInput = false;
                    MessageBox.Show("Invalid End Day Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //checks if end date is before start date and if there is overlap between prevoisly existing reservations. Otherwise adds the reservation
            if (validInput)
            {
                if (endDate <= startDate) { MessageBox.Show("End Date cannot be before or at the same time of Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if (_Car.AddUsageTime(startDate, endDate))
                    {
                        CarDisplay_Load(null, null);
                    }
                }
            }
        }




        //Deletes cars 
        private void deleteCarButton_Click_1(object sender, EventArgs e)
        {
            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Remove the car from the _Cars list and updates car type count
                _registries[_rIndex].decrementCarType(_Car.Type);
                _Cars.Remove(_Car);



                this.Close();
            }
        }

        //Deletes reservation times 
        private void dateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = dateList.SelectedIndex;

            if (selectedIndex >= 0)
            {
                // Confirm the deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this date?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Remove the date tuple from the UsageTimes list
                    _Car.UsageTimes.RemoveAt(selectedIndex);

                    // Refresh the list
                    CarDisplay_Load(null, null);  // This reloads the listbox to reflect changes
                }
            }
        }
    }
}