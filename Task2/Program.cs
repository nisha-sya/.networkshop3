using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            NullOperations nullOps = new NullOperations();

            Console.WriteLine("=== Null Operations Demo ===");
            nullOps.PerformNullChecks();

            Console.WriteLine("\nAll null operation checks executed successfully!");
        }
    }
}
