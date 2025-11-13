using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace WorkshopTasks
{
    public class LoopExamples
    {
        public void SumFrom1ToN()
        {
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum from 1 to {n} = {sum}");
        }

        public void WhileLoopExample()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // Skip multiples of 4
                }

                if (i == 15)
                    break; // Stop when number is 15

                Console.WriteLine(i);
                i++;
            }
        }

        public void ArraySum()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int num in numbers)
                sum += num;

            Console.WriteLine($"Sum of array elements = {sum}");
        }
    }
}
