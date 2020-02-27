/* Practical 7: 
 * Write a C# code to Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            float centigrade, fahrenheit;
            
            //Take temperature form user
            Console.Write("Enter temperature in centigrade:  ");
            centigrade = float.Parse(Console.ReadLine());

            //Convert from centigrade to fahrenheit
            fahrenheit = centigrade * 9 / 5 + 32;
            Console.WriteLine($"{centigrade}°C = {fahrenheit}°F");
            Console.Read();
        }
    }
}
