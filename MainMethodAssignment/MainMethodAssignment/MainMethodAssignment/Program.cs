using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
   
    class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            mathoperations mathOps = new mathoperations();

            // Call the integer method
            int intResult = mathOps.PerformOperation(10);
            Console.WriteLine($"Integer operation result: {intResult}");

            // Call the decimal method
            int decimalResult = mathOps.PerformOperation(7.5m);
            Console.WriteLine($"Decimal operation result: {decimalResult}");

            // Call the string method
            int stringResult = mathOps.PerformOperation("15");
            Console.WriteLine($"String operation result: {stringResult}");

            // Pause console to see results before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
