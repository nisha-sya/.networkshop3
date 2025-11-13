using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionExamples ex = new ExceptionExamples();

            Console.WriteLine("=== Try-Catch-Finally Demo ===");
            ex.NumberConversion();

            try
            {
                ex.PasswordCheck();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\nException handling demo completed successfully!");
        }
    }
}
