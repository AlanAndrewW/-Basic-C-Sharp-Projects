using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method with two numbers (positional arguments)
            Console.WriteLine("Calling method with positional arguments:");
            mathOps.PerformOperation(10, 5);

            Console.WriteLine(); // Blank line for readability

            // Call the method using named parameters
            Console.WriteLine("Calling method with named arguments:");
            mathOps.PerformOperation(number1: 7, number2: 3);

            // Pause console to see results before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
