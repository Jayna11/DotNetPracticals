/* Practical 2
 * Write C# code to prompt a user to input his/her name and country name 
 * and then the output will be shown as an example below: 
 * Hello Ram from country India!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            Console.WriteLine("Hello! Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            country = Console.ReadLine();

            Console.WriteLine($"Hello {name} from country {country}");
            Console.Read();
        }
    }
}
