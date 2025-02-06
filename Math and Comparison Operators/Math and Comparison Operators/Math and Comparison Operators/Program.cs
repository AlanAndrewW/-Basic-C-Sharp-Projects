using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Math_and_Comparison_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print "Anonymous Income Comparison Program" to Console
            Console.WriteLine("Anonymous Income Comparison Program");
       
            Console.WriteLine("Person 1");//Print "Person 1" to Console
            Console.WriteLine("Hourly Rate: ");//Print Hourly Rate to Console
            String hourlyRate1 = Console.ReadLine();//HourlyRate1 is defined as type string with a value of users input
            Console.WriteLine("Hours Worked Per Week: ");//Prints "Hours worked per week"
            String hoursPerWeek1 = Console.ReadLine();//hoursPerWeek is defined as type string with value of users input
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hoursPerWeek1) * 52;//Salary 1 is defined as type integer, the sum of salary 1 will be the value of hourlyrate1 and hoursperweek1 multiplied after being converted to Integers AND THEN multiplied by the number of weeks in a year. "52".
            Console.WriteLine("Person 1 Salary: " + salary1);//Print "Person 1 Salary" plus the sum of salary1 to console.
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            String hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours Worked Per Week: ");
            String hoursPerWeek2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hoursPerWeek2) * 52;
            Console.WriteLine("Person 2 Salary: " + salary2);
            Console.ReadLine();

            bool trueOrFalse = salary1 > salary2;
            Console.WriteLine("Does Person1 Have A Higher Salary Than Person 2? Please answer True or False: ");
            Console.ReadLine();
            Console.Write(trueOrFalse);            
        }
    }
}
