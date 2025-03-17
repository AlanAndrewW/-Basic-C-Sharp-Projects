using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Employee class that inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Implementing the SayName method inherited from Person
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implementing the Quit method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine("The employee has quit.");
        }
    }
}
