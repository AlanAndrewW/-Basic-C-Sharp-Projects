using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose A Number Between 1 and 10: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());//Grabbing user input for guessed number
            bool corGuess = guessNumber == 6;//Assigning the correct Guess Number to 6

            do//telling console to run loop while the guessed answer is not equal to 6
            {
                switch (guessNumber)
                {
                    //if user input is 1
                    case 1:

                        Console.WriteLine("You Picked Number 1. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 2
                    case 2:

                        Console.WriteLine("You Picked Number 2. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 3
                    case 3:

                        Console.WriteLine("You Picked Number 3. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 4
                    case 4:

                        Console.WriteLine("You Picked Number 4. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 5
                    case 5:

                        Console.WriteLine("You Picked Number 5. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 7
                    case 7:

                        Console.WriteLine("You Picked Number 7. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 8
                    case 8:

                        Console.WriteLine("You Picked Number 8. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 9
                    case 9:

                        Console.WriteLine("You Picked Number 9. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is 10
                    case 10:

                        Console.WriteLine("You Picked Number 10. This Is Incorrect. Please Try Again.");

                        Console.WriteLine("Please Enter A Number: ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        break;// will reset the user input

                    //if user input is correct and answer is 6
                    case 6:

                        Console.WriteLine("You Picked Number 6...");
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine("You Win!");
                        corGuess = true;
                        break;// end loop
                }
            } 
            while (!corGuess);
            Console.ReadLine();
        }
    }
}
