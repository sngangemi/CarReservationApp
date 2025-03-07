using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservation
{
    public class CarRegistry
    {

        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public int sedanCount = 0;
        public int SUVCount = 0;
        public int vanCount = 0;

        //Establish max cars of each type allowed
        int maxSedanCount = 5;
        int maxSUVCount = 5;
        int maxVanCount = 5;

        //Initilzation
        public CarRegistry(string name)
        {
            Name = name;
            Cars = new List<Car>(); // Initialize the Cars list
        }

        //decrement type of car spesfied by 1 (to be done when car is removed)
        public void decrementCarType(Car.CarType carType)
        {
            if (carType == Car.CarType.Sedan)
            {
                sedanCount--;
            }
            else if (carType == Car.CarType.SUV)
            {
                SUVCount--;
            }
            else
            {
                vanCount--;
            }
        }

        //Checks if there is currently less than the allowed mount of cars for the type of car being added, and adds it if otherwise
        public void AddCar(Car car)
        {   //Checks if there is currently less than the allowed mount of cars for the type of car being added
            if ((car.Type == Car.CarType.Sedan && sedanCount<maxSedanCount) || (car.Type == Car.CarType.SUV && SUVCount<maxSUVCount) ||(car.Type == Car.CarType.Van && vanCount<maxVanCount)                )
            {
                Cars.Add(car);
                if (car.Type == Car.CarType.Sedan)
                {
                    sedanCount++;
                }
                else if (car.Type == Car.CarType.SUV)
                {
                    SUVCount++;
                }
                else if (car.Type == Car.CarType.Van)
                {
                    vanCount++;
                }
            }
            else
            {

                MessageBox.Show("Too Many Cars of this type are already existing in car registry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
