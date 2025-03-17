using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassassignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate the Employee object and initialize it with values
            Employee employee = new Employee
            {
                FirstName = "Sample",  // Set the first name to "Sample"
                LastName = "Student"   // Set the last name to "Student"
            };

            // Call the SayName() method on the Employee object
            // This prints the full name of the employee
            employee.SayName();

            // Pause the console so that we can see the output before the program closes
            Console.ReadKey();
        }
    }
}
