using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassassignment
{
    // Employee class that inherits from Person
    public class Employee : Person
    {
        // Implementing the SayName() method inherited from Person
        public override void SayName()
        {
            // Print the full name to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
