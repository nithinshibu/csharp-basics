using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Section_8
{
    public abstract class Appliance
    {
        // Abstract method (does not have a body)
        public abstract void Operate();

        // Regular method
        public void DisplayInfo()
        {
            Console.WriteLine("Appliance details:");
        }
    }

    public class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("The washing machine is now washing clothes!");
        }

        public void StartSpinCycle()
        {
            Console.WriteLine("The washing machine is starting the spin cycle.");
        }
    }

    public class Refrigerator : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("The refrigerator is now cooling food!");
        }

        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"The refrigerator temperature is set to {temperature} degrees.");
        }
    }


}
