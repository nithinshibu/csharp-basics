using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Section_Async_Await
{
    public class SynchronousExample
    {
        public void MakeTea()
        {
            DateTime dateTimeBefore = DateTime.Now;            
            BoilWater();      // Takes 5 minutes
            AddTeaBag();      // Takes 1 minute
            Console.WriteLine("Tea is ready!");
            DateTime dateTimeAfter = DateTime.Now;
            TimeSpan timeSpan = dateTimeAfter.Subtract(dateTimeBefore);
            Console.WriteLine($"Total time for operations to complete is {timeSpan.Seconds} seconds ");
        }

        public void BoilWater()
        {
            Thread.Sleep(5000); // Simulates 5 seconds of waiting
            Console.WriteLine("Water is boiled.");
        }

        public void AddTeaBag()
        {
            Thread.Sleep(1000); // Simulates 1 second of waiting
            Console.WriteLine("Tea bag added.");
        }
    }
}
