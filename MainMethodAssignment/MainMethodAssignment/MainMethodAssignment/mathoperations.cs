using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class mathoperations
    {
        // Method 1: Takes an integer, adds 10, and returns the result
        public int PerformOperation(int number)
        {
            return number + 10;
        }

        // Method 2: Takes a decimal, multiplies by 2, and returns the result as an integer
        public int PerformOperation(decimal number)
        {
            return (int)(number * 2);
        }

        // Method 3: Takes a string, converts to an integer, subtracts 5, and returns the result
        public int PerformOperation(string number)
        {
            if (int.TryParse(number, out int result))
            {
                return result - 5;
            }
            else
            {
                // If the conversion fails, return 0 (or you can throw an exception)
                Console.WriteLine("Invalid input. Could not convert string to integer.");
                return 0;
            }
        }
    }
}
