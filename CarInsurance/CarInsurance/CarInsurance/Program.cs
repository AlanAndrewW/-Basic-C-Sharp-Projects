using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    internal class Program
    {
        private static int a_ExitCode; //Creating an exit that will stop the user from continuing to run program if they do not meet all of the requirements

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AA Auto Insurance Qualifier Program.");
            Console.WriteLine("Please Enter Your Age: ");//printing welcome and enter age to console.
            int age1 = Convert.ToInt32(Console.ReadLine());//converting int age1 to floatpoint val and assigning the value to user input
            int age2 = Convert.ToInt32(15);//converting int age2 to floatpoint val and assigning the value to 15
            bool isOldEnough = (age1 >= age2);// assigning boolean. checking if age1(user input value) is greater than or equal to age2(assinged value) 
            if (isOldEnough)//Conditional Statement
            {
                Console.WriteLine("You Qualify! Please Hit Enter.");
            }
            else//conditional statement
            {
                Console.WriteLine("Sorry, But You Are Not Old Enough! Please Terminate The Qualifier Program By Hitting Any Key And Return When You Are Old Enough To Qualify!");
                System.Environment.Exit(a_ExitCode);//Exit Program if not old enough
            }
            Console.ReadLine();
            Console.WriteLine("Have You Ever Been Charged With a DUI? Please Enter Either '1' for True or '2' for Talse: "); // printing DUI question to console
            int dUI1 = Convert.ToInt32(Console.ReadLine());
            int dUI2 = Convert.ToInt32(2);
            bool ifDui = (dUI1 != dUI2);// assigning boolean. checking if dUI1(user input value) is True or False  to dUI2(assinged value) *HAVE THEY HAD DUI*
            if (ifDui)//conditional statement
            {
                Console.WriteLine("Were Sorry, But you Do Not Qualify If You've Ever Had A DUI. Please Hit Any Key To Terminate The Program");
                System.Environment.Exit(a_ExitCode);//Exit program if have had DUI
            }
            else//conditional statement
            {
                Console.WriteLine("Great! Let's Continue! Please Press Enter To Continue!");
            }
            Console.ReadLine();
            Console.WriteLine("How Many Speeding Tickets Have You Had?: ");// Printing Speeding Tickets Question to Console.
            int speedTix1 = Convert.ToInt32(Console.ReadLine());
            int speedTix2 = Convert.ToInt32(3);
            bool SpeedTix = (speedTix1 > speedTix2);// assigning boolean. checking if speedTix1(user input value) is greater than 3  (assinged value of SpeedTix2 is 3) *Cant have more than 3 Speeding tix
            if (SpeedTix)
            {
                Console.WriteLine("We're Sorry, But You Have Too Many Speeding Tickets To Qualify. Please Hit Any Key To Terminate The Program.");
                System.Environment.Exit(a_ExitCode);//Exit if too many speeding tix
            }
            else
            {
                Console.WriteLine("Perfect! You Qualify! Please Hit Enter To Recieve Our Toll-Free Telephone Number And Private E-Mail Address!");//User successfuly qualified and will recieve contact info
            }
            Console.ReadLine();
            Console.WriteLine("Please Call Us At 1-800-485-0090 To Make Arrangements Or Contact Us By Our E-Mail Address At aacarinsure.net ! Thank You For Your Patience! The Program Will Now Terminate.");//user recieves contact info
            System.Environment.Exit(a_ExitCode);//Program Exits
        }
    }
}
