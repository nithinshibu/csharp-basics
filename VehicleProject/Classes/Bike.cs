using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProject.Interface;

namespace VehicleProject.Classes
{
    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The bike is starting.");
        }

    }
}
