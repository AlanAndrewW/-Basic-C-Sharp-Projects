using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list of ints.
            List<int> ints = new List<int>() { 100, 40, 1000, 10000, 90, 69, 6000, 4000, 25000, 40000 };
            //Ask for user input & loop through list dividing each # by user input
            bool numValid = false;
            while (!numValid)
            {
                //using try/catch for error message
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    //If statement checks if user enters 0
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number different from 0.");
                    }
                    //divide each number in list by user input
                    else
                    {
                        foreach (int num in ints)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + "=" + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input invalid. Please enter digits.");
                }
            }
            Console.WriteLine("The program is terminating now.");
        }
    }
}
