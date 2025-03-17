using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Prompt the user for the first number
            Console.Write("Enter the first number: ");
            int number1;
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            // Prompt the user for the second number (optional)
            Console.Write("Enter the second number (or press Enter to skip): ");
            string input = Console.ReadLine();

            int result;
            if (int.TryParse(input, out int number2))
            {
                // If user entered a valid second number, call the method with both numbers
                result = mathOps.PerformOperation(number1, number2);
                Console.WriteLine($"Result of adding {number1} and {number2}: {result}");
            }
            else
            {
                // If no valid second number was entered, call the method with only the first number
                result = mathOps.PerformOperation(number1);
                Console.WriteLine($"Result of adding {number1} and default (5): {result}");
            }

            // Pause console to see results before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
