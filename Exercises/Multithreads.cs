using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{

    public class Multithreads
    {
        static int counter = 0;

        public static void Multithreadss()
        {
            // Create and start tasks
            Task task1 = Task.Run(() => IncrementCounter());
            Task task2 = Task.Run(() => IncrementCounter());

            // Wait for both tasks to complete
            Task.WaitAll(task1, task2);

            // Output final value of the counter
            Console.WriteLine("Final counter value: " + counter);
        }

        // Method to increment the counter 1000 times with thread safety
        public static void IncrementCounter()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref counter);
            }
        }
    }
}
