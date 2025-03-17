using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsandobjectsassignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            // Set the first name to "Sample", last name to "Student", and the employee ID to 12345
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 12345
            };

            // Call the SayName method, which is inherited from the Person class
            employee.SayName();

            // Pause the program so that the output is visible before the console closes
            Console.ReadKey();
        }
    }
}