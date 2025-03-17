using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // Define the Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for Employee First Name
        public string FirstName { get; set; }

        // Property for Employee Last Name
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both Employee objects are the same instance (if both are null or the same reference)
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If any of the Employee objects is null, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Id properties of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to compare two Employee objects based on their Id (opposite of "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);  // Use the already overloaded "==" operator to return the opposite result
        }

        // Override the Equals method to maintain consistency with the "==" operator overload
        public override bool Equals(object obj)
        {
            // If the object is not an Employee or is null, return false
            if (obj == null || !(obj is Employee))
                return false;

            // Compare the Id properties
            return this.Id == ((Employee)obj).Id;
        }

        // Override the GetHashCode method to maintain consistency with the Equals method
        public override int GetHashCode()
        {
            return Id.GetHashCode();  // Use Id's hash code for consistency
        }
    }
}
