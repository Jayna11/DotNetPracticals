/*Practical 3: Write C# code to do the  following 
 * Convert binary to decimal 
 * Convert decimal to hexadecimal 
 * Convert decimal to binary 
 * Convert decimal to octal
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryString;
            int decimalNumber;
            bool flag = true; //to display error message while user enters invalid binary number

            //Take and validate user input in string format
            Console.WriteLine("Enter a binary number(31 bit Max)");
            do
            {
                if (!flag) //Only execute if user enters anything except 0 and 1
                    Console.WriteLine("Please enter a valid binary value");
                binaryString = Console.ReadLine();
                flag = false; //will display error message in every subsequent iteration of this loop (if this loop continuous)
            } while (!Regex.IsMatch(binaryString, @"^[01]+$")); //Checking input string for anything other than 0s and 1s

            ConvertBinaryToDecimal(binaryString, out decimalNumber);
            Console.WriteLine("Answer: " + decimalNumber);

            Console.Read();
        }

        /// <summary>
        /// Converts a string of 0s and 1s to equivalent decimal number
        /// </summary>
        /// <param name="binaryString">string of 0s and 1s</param>
        /// <param name="decimalNumber">store the converted decimal number</param>
        private static void ConvertBinaryToDecimal(string binaryString, out int decimalNumber)
        {
            //Variable declaration and initialisation
            decimalNumber = 0; //To store converted decimal number
            int bit; //to store individual bit from right to left while calculating decimal from binary
            int powerCounter = 0; //To manage the exponent of 2
           
            //Convertion of Binary to Decimal
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                bit = int.Parse(binaryString[i].ToString());
                decimalNumber += bit * (int)Math.Pow(2, powerCounter++);
            }
        }
    }
}
