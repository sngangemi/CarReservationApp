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
    public partial class Home : Form
    {
        private List<CarRegistry> _registries;

        //Initialize
        public Home(List<CarRegistry> registries)
        {
            InitializeComponent();
            _registries = registries;
        }

        //Load homescreen based off current registries available
        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the ListBox with the registries
            RegistryList.Items.Clear(); // Clear the list box before populating
            foreach (var registry in _registries)
            {
                Console.WriteLine(registry.Name);
                RegistryList.Items.Add(registry.Name); // Add each registry's name
            }
        }

        //Select registry to delete or edit
        private void RegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RegistryList.SelectedIndex;
            if (selectedIndex >= 0)
            {
                RegDisplay regDisplay = new RegDisplay(_registries,selectedIndex);
                regDisplay.ShowDialog();
                Form1_Load(null, null);
            }
        }

        //Create new registry
        private void registryNameButton_Click(object sender, EventArgs e)
        {
            if (registryNameInput.Text.Length >3)
            {
                string newRegName = registryNameInput.Text;
                CarRegistry newReg= new CarRegistry(newRegName);
                _registries.Add(newReg);
                RegistryList.Items.Add(newRegName);

            }
            else
            {
                MessageBox.Show("Registry names must be greater than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
