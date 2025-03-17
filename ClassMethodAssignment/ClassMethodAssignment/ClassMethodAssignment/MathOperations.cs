using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    // Declaring the class as static since we only need utility methods.
    public static class MathOperations
    {
        // Void method that takes an integer, divides it by 2, and outputs the result.
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2; // Divide the number by 2
        }

        // Method with output parameters: returns the square and cube of a number.
        public static void GetSquareAndCube(int number, out int square, out int cube)
        {
            square = number * number; // Compute square
            cube = number * number * number; // Compute cube
        }

        // Overloaded method: Performs division but with a decimal value.
        public static void DivideByTwo(decimal number, out decimal result)
        {
            result = number / 2; // Divide the decimal by 2
        }
    }
}
