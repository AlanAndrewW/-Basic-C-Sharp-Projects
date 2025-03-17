using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a number
            Console.Write("Enter an integer to divide by two: ");

            // Read user input and convert to an integer
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                // Call the DivideByTwo method and display the result
                MathOperations.DivideByTwo(userNumber, out int divisionResult);
                Console.WriteLine($"Result of {userNumber} divided by 2: {divisionResult}");

                // Call the method with output parameters to get square and cube
                MathOperations.GetSquareAndCube(userNumber, out int square, out int cube);
                Console.WriteLine($"Square of {userNumber}: {square}");
                Console.WriteLine($"Cube of {userNumber}: {cube}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            Console.WriteLine(); // Blank line for readability

            // Demonstrating method overloading with a decimal number
            Console.Write("Enter a decimal number to divide by two: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal userDecimal))
            {
                MathOperations.DivideByTwo(userDecimal, out decimal decimalResult);
                Console.WriteLine($"Result of {userDecimal} divided by 2: {decimalResult}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid decimal number.");
            }

            // Pause console to see results before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
