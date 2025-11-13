using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace WorkshopTasks
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            // Using ternary operator (? :)
            Console.WriteLine(username == null ? "Username is not available" : username);

            // Using null-coalescing operator (??)
            Console.WriteLine(username ?? "Username is not available (checked with ??)");

            // Using null-coalescing assignment operator (??=)
            username ??= "DefaultUser";
            Console.WriteLine($"Updated username: {username}");
        }
    }
}
