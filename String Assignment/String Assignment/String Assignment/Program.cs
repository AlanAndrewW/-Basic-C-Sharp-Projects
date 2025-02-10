using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////concatenate 3 strings
            //string first = "Hello";
            //string second = " my name is";
            //string third = " Alan.";

            //Console.WriteLine(String.Concat(first, second, third));

            ////Convert String to uppercase
            //first = first.ToUpper();
            //Console.Write(first);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello  my name is  Alan. It has been a very long day for me.");
            sb.Append("\nHow are you?\nI myself haven't gotten much sleep and I am Exhausted.\n");
            sb.Append("I hope your day is going well!");
            Console.WriteLine(sb);
            Console.ReadLine();
           //using stringbuilder to create paragraph of text

           
        }
    }
}
