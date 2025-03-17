using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassassignment
{
    // Abstract class Person. Cannot be instantiated directly.
    public abstract class Person
    {
        // Property to store the first name of the person
        public string FirstName { get; set; }

        // Property to store the last name of the person
        public string LastName { get; set; }

        // Abstract method that must be implemented in the derived class
        public abstract void SayName();
    }
}
