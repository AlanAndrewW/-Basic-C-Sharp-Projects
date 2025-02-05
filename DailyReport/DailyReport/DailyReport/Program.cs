using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("academy of learning college");
            //prints academy of learning college
            Console.WriteLine("student daily report");
            // prints student daily report
            Console.WriteLine("what is your first/last name?: ");
            string name = Console.ReadLine();
            //  allows user to input Name string
            Console.WriteLine("Which Course Are You On? ");
            string course = Console.ReadLine();
            //allows user to input Course string
            Console.WriteLine("Which Page Number Are You On? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // int Stores whole numbers from -2,147,483,648 to 2,147,483,647. Here we are converting possible string input into integers.  
            Console.WriteLine("Do You Need Assistance? Please Answer Either \"True\" or \"False\".");
            string needAssistance = Console.ReadLine();
            bool needAssistanceBool = bool.Parse(needAssistance);
            //here we are creating a boolean. bool.parse converts the string of true/false to boolean
            Console.WriteLine("Please Provide Any Positive Experiences You May Have Had in Great Detail.");
            string positiveExperiences = Console.ReadLine();
            // //allows user to input feedback string
            Console.WriteLine("Is There Anything Else You'd Like to Provide Feedback On?");
            string feedback = Console.ReadLine();
            // //allows user to input feedback string
            Console.WriteLine("How Many Hours did You Study Today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            // int Stores whole numbers from -2,147,483,648 to 2,147,483,647. Here we are converting possible string input into integers.
            Console.WriteLine("Thank You Very much. An Instructor Will Respond To This Shortly. Have a Nice Day.");
            Console.ReadLine();
            //end program
        }
    }
}
