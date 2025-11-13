using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            DayFinder dayFinder = new DayFinder();

            Console.WriteLine("=== Switch Case Demo ===");
            dayFinder.FindDay();

            Console.WriteLine("\nDay finder executed successfully!");
        }
    }
}
