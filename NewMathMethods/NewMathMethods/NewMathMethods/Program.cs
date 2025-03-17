using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMathMethods
{


    class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user for a number
            Console.Write("Enter a number to perform math operations on: ");

            // Read user input and convert it to an integer
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                // Call each method and display the results
                Console.WriteLine($"Adding 10: {mathOps.AddTen(userNumber)}");
                Console.WriteLine($"Multiplying by 2: {mathOps.MultiplyByTwo(userNumber)}");
                Console.WriteLine($"Subtracting 5: {mathOps.SubtractFive(userNumber)}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            // Pause console to see results before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
