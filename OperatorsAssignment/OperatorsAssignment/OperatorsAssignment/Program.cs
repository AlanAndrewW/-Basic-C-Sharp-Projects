using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            // Create two Employee objects and assign values to their properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };
            Employee employee3 = new Employee { Id = 2, FirstName = "Mike", LastName = "Johnson" };

            // Compare the first two employees using the overloaded "==" operator
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same.");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are different.");
            }

            // Compare the second and third employees using the overloaded "==" operator
            if (employee2 == employee3)
            {
                Console.WriteLine("Employee 2 and Employee 3 are the same.");
            }
            else
            {
                Console.WriteLine("Employee 2 and Employee 3 are different.");
            }

            // Compare the first and third employees using the overloaded "!=" operator
            if (employee1 != employee3)
            {
                Console.WriteLine("Employee 1 and Employee 3 are different.");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 3 are the same.");
            }

            // Pause the console so that we can see the output before the program closes
            Console.ReadKey();
        }
    }
}
