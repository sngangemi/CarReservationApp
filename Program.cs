using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarReservation.Car;

namespace CarReservation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<CarRegistry> registries = new List<CarRegistry>();

            

            // Example of adding registries with cars
            var registry1 = new CarRegistry("Default Registry 1");
            registry1.AddCar(new Car(CarType.Sedan, "ABC123"));  
            registry1.AddCar(new Car(CarType.SUV, "XYZ456"));
            registries.Add(registry1);

            var registry2 = new CarRegistry("Default Registry 2");
            registry2.AddCar(new Car(CarType.Van, "LMN789"));
            registries.Add(registry2);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(registries));
        }
    }
}
