using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class MathOperations
    {
        // This method takes two integers as parameters.
        // It performs a math operation on the first integer (multiplication by 2)
        // and displays the second integer to the console.
        public void PerformOperation(int number1, int number2)
        {
            int result = number1 * 2; // Multiply the first number by 2
            Console.WriteLine($"Result of multiplying {number1} by 2: {result}");
            Console.WriteLine($"Second number provided: {number2}");
        }
    }
}