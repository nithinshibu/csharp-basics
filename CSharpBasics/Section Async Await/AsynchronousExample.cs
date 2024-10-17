using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Section_Async_Await
{
    public class AsynchronousExample
    {
        public async Task MakeTeaAsync()
        {
            DateTime dateTimeBefore = DateTime.Now;
            Task boilWaterTask = BoilWaterAsync();  // Start boiling water
            PrepareSnacks();                        // While water boils, prepare snacks
            await boilWaterTask;                    // Wait for water to finish boiling
            AddTeaBag();                            // Add the tea bag after boiling
            Console.WriteLine("Tea is ready!");
            DateTime dateTimeAfter = DateTime.Now;
            TimeSpan timeSpan = dateTimeAfter.Subtract(dateTimeBefore);
            Console.WriteLine($"Total time for operations to complete is {timeSpan.Seconds} seconds ");
        }

        public async Task BoilWaterAsync()
        {
            await Task.Delay(5000);  // Simulates 5 seconds of waiting asynchronously
            Console.WriteLine("Water is boiled.");
        }

        public void PrepareSnacks()
        {
            Console.WriteLine("Snacks are prepared.");
        }

        public void AddTeaBag()
        {
            Console.WriteLine("Tea bag added.");
        }

    }
}
