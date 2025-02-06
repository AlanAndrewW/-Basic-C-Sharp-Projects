using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
     class Program
    {
        static void Main(string[] args)
        {
            //////Takes user input, multiples it by 50, then prints to console//
            int num1;
            int num2 = 50;

            int total;

            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            total = num1 * num2;
            Console.WriteLine("Your Number Multiplied by 50 is: " + total);
            Console.ReadLine();


            ////Takes user input, adds it by 25 and prints to console//
            int num3;
            int num4 = 25;

            int total1;

            Console.WriteLine("Please Enter another Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            total1 = num3 + num4;
            Console.WriteLine("Your Number after adding 25 is: " + total1);
            Console.ReadLine();


            ////Takes input from user, divides it by 12.5, and prints to console//
            int num5;
            double num6 = 12.5;

            double total2;

            Console.WriteLine("Please Enter another Number: ");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            total2 = num5 / num6;
            Console.WriteLine("Your Number after deviding by 12.5 is: " + total2);
            Console.ReadLine();


            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            bool trueOrFalse = 69 <= 96;
            Console.WriteLine("Is 69 greater than 96?: ");
            Console.ReadLine();
            Console.Write(trueOrFalse.ToString());

            // Prompt the user to enter a number
            Console.WriteLine("Please enter a number: ");

            // Read input and convert it to an integer
            int num = Convert.ToInt32(Console.ReadLine());

            // Divide the number by 7 and calculate the remainder
            int remainder = num % 7;

            // Print the remainder
            Console.WriteLine($"The remainder when {num} is divided by 7 is: {remainder}");





        }
    }
}
