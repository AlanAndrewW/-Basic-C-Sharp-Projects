using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathOperations
    {
        // Method that takes two integers, with the second one being optional (default value = 5)
        public int PerformOperation(int number1, int number2 = 5)
        {
            // Performs addition and returns the result
            return number1 + number2;
        }
    }
}

