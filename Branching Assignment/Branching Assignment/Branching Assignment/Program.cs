using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        private static int exitCode;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");//Welcome Printed


            Console.WriteLine("Please Enter Your package Weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());//gather weight info from user input
            if (weight > 50)//conditional statement. if weight over 50 program will terminate
            {
                Console.WriteLine("Package Too Heavy To Be Shipped via Package Express. Have A Good Day.");
                System.Environment.Exit(exitCode);
            }
            else
            {
                Console.WriteLine("Thank You.");//thank you will be printed
            }

            Console.WriteLine("Please Enter Your Package Width: ");
            int width = Convert.ToInt32(Console.ReadLine());//gather width info from user input
            if (width > 50)//conditional statement. if width over 50 program will terminate
            {
                Console.WriteLine("Package Too Wide To Be Shipped via Package Express. Have A Good Day");
                System.Environment.Exit(exitCode);
            }
            else
            {
                Console.WriteLine("Thank You.");
            }


            Console.WriteLine("Please Enter Your Package Height: ");
            int height = Convert.ToInt32(Console.ReadLine());//conditional statement. if height over 50 program will terminate

            if (height > 50)
            {
                Console.WriteLine("Package Too Tall To Be Shipped via Package Express. Have A Good Day");
                System.Environment.Exit(exitCode);
            }
            else
            {
                Console.WriteLine("Thank You.");
            }


            Console.WriteLine("Please Enter Your Package Length: ");
            int length = Convert.ToInt32(Console.ReadLine());//conditional statement. if length over 50 program will terminate

            if (length > 50)
            {
                Console.WriteLine("Package Too Long To Be Shipped via Package Express. Have A Good Day");
                System.Environment.Exit(exitCode);
            }
            else
            {
                Console.WriteLine("Thank You.");
            }

            Console.WriteLine("Your Dimensions Are: " + width + " inches x " +  height + " inches x " + length + " Inches.");//print overall dimensions
            decimal price = width * height * length / 100m;// calculating cost
            Console.WriteLine("Your Estimated Total will come to: " + price + "$");//printing cost
            Console.WriteLine("Please Visit Our Nearest Location For More Info Or Call 1-800-478-9999.\n Thank You And Have A Wonderful Day.");
            System.Environment.Exit(exitCode);//program will terminate on key press
        }
    }
}
