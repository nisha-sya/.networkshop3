using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace WorkshopTasks
{
    public class ExceptionExamples
    {
        public void NumberConversion()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public void PasswordCheck()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");
            else
                Console.WriteLine("Password satisfied the requirement");
        }
    }
}
