using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object and initialize it with values
            Employee employee = new Employee
            {
                FirstName = "Sample",  // Set the first name to "Sample"
                LastName = "Student"   // Set the last name to "Student"
            };

            // Demonstrating polymorphism by creating an IQuittable reference
            // IQuittable can refer to any object that implements the Quit() method
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the IQuittable reference
            quittableEmployee.Quit();

            // Pause the console so that we can see the output before the program closes
            Console.ReadKey();
        }
    }
}
