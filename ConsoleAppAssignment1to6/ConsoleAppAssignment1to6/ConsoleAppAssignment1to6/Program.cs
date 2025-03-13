using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1to6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//Pt1 - Create 1 dimensional array of strings
                string[] wordstart = { "Hi, Here we are at the ", "I am Officer ", "I'd like you to join our " };
                string[] wordend = { " Police Department.", ".", " Police Task Force." };
                List<string> responses = new List<string>();
                //user text input
                Console.WriteLine("Please enter a noun: ");
                responses.Add(Console.ReadLine());
                Console.WriteLine("Please enter the name of somebody famous: ");
                responses.Add(Console.ReadLine());
                Console.WriteLine("Please enter an adjective: ");
                responses.Add(Console.ReadLine());
                //create loop going through each string in array, add users text to string.
                for (int i = 0; i < wordstart.Length; i++)
                {
                    wordstart[i] += responses[i];
                    Console.WriteLine(wordstart[i] + wordend[i]);
                }
                Console.ReadLine();
                Console.WriteLine("The strings we used: ");//create a loop that prints off each of the strings in array on seperate line
                for (int i = 0; i < wordstart.Length; i++)
                {
                    Console.WriteLine(wordstart[i] + wordend[i]);
                    //Pt2 create infinite loop uncomment line i-- for infinite loop, fix infinite loop 
                }
                Console.ReadLine();
                //Pt3
                Console.WriteLine("Is that a car?!");
                StringBuilder vroom = new StringBuilder();
                vroom.Append("V");
                //create a loop where the comparison thats used to determine whether to continue iterating the loop is a "<" operator.
                while (vroom.Length < 10)
                {
                    vroom.Append("room");
                }
                vroom.Append("!");
                Console.ReadLine();
                Console.WriteLine(vroom);
                Console.ReadLine();
                StringBuilder lookout = new StringBuilder();
                lookout.Append("Ag");
                //Add a loop where the comparison thats used to determine whether to continue iterating the loop is a "<=" operator
                while (lookout.Length <= 10)
                {
                    lookout.Append("h");
                }
                lookout.Append(" Lookout!");
                Console.WriteLine(lookout);
                Console.ReadLine();

                //Pt4 Create a list of strings where each  item in the list is unique
                List < string > bands = new List<string>() { "Red Hot Chilli Peppers", "Sum 41", "White Stripes", "The Rolling Stones", "The monkeys", "The B-52's", "AC/DC", "Metallica", "Queens of The Stone Age", "Slayer", "Dragon Force", "Iggy Pop", "David Bowie" };
                Console.WriteLine("Best bands of all time");
                Console.WriteLine("Enter band name: ");
                int band = 0;
                bool isValid = false;
                int index = 0;
                //create loop that iterates through list and then displays index of the array that contains matching text on the screen.
                while (!isValid)
                {
                    int i2 = 0;
                    string bandrequest = Console.ReadLine();
                    foreach (string bandz in bands)
                    {
                        if (bandrequest == bandz)
                        {
                            band = i2 + 1;
                            index = i2;
                        }
                        i2++;
                    }
                    //add code to that above loop that tells a user if they put in text that isnt in list.
                    if (band == 0)
                    {
                        Console.WriteLine("That is not one of the greatest bands of all time. Please enter a band that doesn't suck: ");
                    }
                    //add code to above loop that stops it from executing once a match is found.
                    else
                    {
                        isValid = true;
                    }
                }
                Console.WriteLine("Processing... Index is: " + index + ". So...");
                Console.WriteLine("Band is: " + band);
                Console.ReadLine();

                //Pt5 create a list of strings that has at least two identical strings in the list
            List<string> rooms = new List<string>()
            { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "taken" };
                Console.WriteLine("Hello! Welcome to the Hotel Hell check in! \nIf you have a reservation type " + "\"Reserved\".\nIf you are joining a party that is already here, type \"Taken\".\nOtherwise type \"Vacant\".");
                //asks user to select text to search for in list
                Console.WriteLine("Enter selection: ");
                string selection = Console.ReadLine();
                while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
                {
                    //Add code that tells user if they entered text that was not in list.
                    Console.WriteLine("Please enter 1 of 3 choices: ");
                    selection = Console.ReadLine();
                }
                Console.WriteLine("The rooms that match your selection are numbered: ");
                //create a loop that iterates through loop and displays indices of array containing matching text on screen
                for (int i3 = 0; i3 < rooms.Count; i3++)
                {
                    if (selection == rooms[i3])
                    {
                        Console.WriteLine(i3);
                    }
                }
                Console.ReadLine();

                //Pt6 Create list of strings that have at least 2 identical strings in list
            List<string> names = new List<string>() { "James", "Jimmy", "Roberto", "Rachel", "Ashleigh", "Francine", "Francine" };
                List<string> repeatCheck = new List<string>();
                Console.WriteLine("Class Roster:");
                Create foreach loop thatr evals each item in list and displays message showing the string and whether or not it has already appeared in list
            foreach (string name in names)
                {
                    Console.WriteLine(name);
                    if (repeatCheck.Contains(name))
                    {
                        Console.WriteLine("This name has been repeated. \nUse last name initial while refferencing said student.");
                    }
                    else
                    {
                        Console.WriteLine("This name has not been repeated.");
                    }
                    repeatCheck.Add(name);
                }
                Console.ReadLine();




            }
        }
    }

