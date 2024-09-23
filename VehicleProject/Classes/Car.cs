using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProject.Interface;

namespace VehicleProject.Classes
{
    public  class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car is starting.");
        }

        // Private method: accessible only within this class
        private void DisplayModel()
        {
            Console.WriteLine("Displaying car model.");
        }

        // Protected method: accessible within this class and derived classes
        protected void SetSpeed(int speed)
        {
            Console.WriteLine($"Speed set to {speed} km/h.");
        }

        // Internal method: accessible only within the same assembly
        internal void PerformMaintenance()
        {
            Console.WriteLine("Performing maintenance.");
        }

        // Protected internal method: accessible within the same assembly and derived classes
        protected internal void CheckEngine()
        {
            Console.WriteLine("Checking engine.");
        }
    }

    /*Inheritance (OOPS concept) allows a class to inherit members from another class.*/

    public class SportsCar : Car
    {
        public void TurboBoost()
        {
            // Access the protected method from the base class
            SetSpeed(200);
            CheckEngine();
            Console.WriteLine("Turbo boost activated!");
        }
    }

  
}
