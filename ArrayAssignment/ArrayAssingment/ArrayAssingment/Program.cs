using System;
using System.Collections.Generic;


namespace ArrayAssingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of strings
            string[] stringsPlace = { "United States of America", "Canada", "Mexico", "Japan", "Australia", "Bali", "New Zealand" };
            //get   user input to display string at said index
            Console.WriteLine("Please enter a number between 0 and 6 to find out where you should buy a home: ");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool stringValid = false;

            while (!stringValid)
            {
                try
                {
                    Console.WriteLine("Your new home will be... " + stringsPlace[stringSelect]);
                    stringValid = true;
                }
                //message to user if index # invalid
                catch
                {
                    Console.WriteLine("Sorry, That number is not valid. Please select a number between 0 and 6. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }


            //List of strings
            List<string> movieList = new List<string>()
            { "Idiocracy",
              "Grandma's Boy",
              "Step Brothers",
              "Talladega Nights",
              "Death Note",
              "One Punch Man",
              "Attack On Titan"
            };
            //get user iput to display string at said index
            Console.WriteLine("Please Enter a Number Between 0 and 6 To see what Film/Anime Show you could watch tonight: ");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool listValid = false;

            while (!listValid)
            {
                try
                {
                    Console.WriteLine("Tonight you should watch... " + movieList[listSelect]);
                    listValid = true;
                }
                //message to user if index # invalid
                catch
                {
                    Console.WriteLine("Sorry, That number is not valid. Please select a number between 0 and 6. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
