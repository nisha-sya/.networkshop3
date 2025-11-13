using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            operators op = new operators();

            Console.WriteLine("=== Operator Methods ===");
            op.Add(5, 3);
            op.Subtract(10, 4);
            op.Multiply(6, 2);
            op.Divide(8, 2);
            op.OddEvenFinder(7);

            Console.WriteLine("\nAll operator methods executed successfully!");
        }
    }
}
