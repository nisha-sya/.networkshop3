using System;

namespace WorkshopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopExamples loops = new LoopExamples();

            Console.WriteLine("=== Loop Examples ===");
            loops.SumFrom1ToN();
            loops.WhileLoopExample();
            loops.ArraySum();

            Console.WriteLine("\nAll loop examples executed successfully!");
        }
    }
}
