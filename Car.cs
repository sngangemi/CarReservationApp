using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservation
{

    
    public class Car
    {
        //enumerate car types
        public enum CarType { Sedan, SUV, Van }// Sedan=0,SUV=1,Van=2


        //members with getters and setters establish using auto-ptoperties
        public CarType Type { get; set; }
        public string LicensePlate { get; set; }

        //List of start and and times for reservation
        public List<(DateTime startTime, DateTime endTime)> UsageTimes;
    

        //Initialize
        public Car(CarType type, string licensePlate)
        {
            Type = type;
            LicensePlate = licensePlate;
            UsageTimes = new List<(DateTime, DateTime)>();

        }

        // Checks for overlap with new input reservation and previously existing reservations and adds time if no conflict
        public bool AddUsageTime(DateTime startTime, DateTime endTime)
        {
            // Check if the time overlaps with existing usage times
            foreach (var usage in UsageTimes)
            {
                if (OverlapsWith(usage.startTime, usage.endTime, startTime, endTime))
                {            
                    MessageBox.Show($"Error: The car {LicensePlate} has an overlapping usage time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Add the usage time if no overlap
            UsageTimes.Add((startTime, endTime));

            // Sort the usage times by start time after adding the new entry
            UsageTimes.Sort((a, b) => a.startTime.CompareTo(b.startTime));

            Console.WriteLine($"Car {LicensePlate} usage added from {startTime} to {endTime}.");
            return true;
        }


        // Check if the new usage time overlaps with an existing one
        public bool OverlapsWith(DateTime startTime, DateTime endTime, DateTime newStartTime, DateTime newEndTime)
        {
            return !(newEndTime < startTime || newStartTime > endTime);
        }

    }
}
