using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsandobjectsassignment
{
    // Defining the Person class
    public class Person
    {
        // Property to hold the first name
        public string FirstName { get; set; }

        // Property to hold the last name
        public string LastName { get; set; }

        // Void method to display the full name
        public void SayName()
        {
            // Write the full name to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
