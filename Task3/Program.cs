using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCheck ageCheck = new AgeCheck();

            Console.WriteLine("=== If-Else-If Demo ===");
            ageCheck.CheckAge();

            Console.WriteLine("\nAge check completed successfully!");
        }
    }
}
