using System;

//namespace
namespace NumberGuesser
{
    //Main program
    class Program
    {
        //Entrypoint method
        static void Main(string[] args)
        {
            //Get App info
            GetAppInfo();

            //Greet
            Console.WriteLine("Hi! What's your name ?");

            //take input from users
            string inputName = Console.ReadLine();

            //Welcome user
            Console.WriteLine("Hey {0}, Let's play a guessing game....", inputName);

            //Take the input as number from user
            while (true)
            {
                //create a new random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //Ask player for a number between 1 and 10
                Console.WriteLine("Please enter a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //check if the user input number only
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number only!!!");

                        continue;
                    }

                    //cast to int32 and put into guess
                    guess = Int32.Parse(input);

                    //to check if the guess doesnt matches correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry!, Wrong guess, Try again!!");

                    }
                }
                //set color for success message and print congratulatory message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations {0}!!, You succedded!!!", inputName);

                //Reset terminal color
                Console.ResetColor();

                //Ask user if they want to play again
                Console.WriteLine("Do you want to play again ?\nPlease enter 'y' or 'n'");

                //Take user input
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    continue;
                }
                else if (userInput == "n")
                {
                    return;
                }
                else
                {
                    return;
                }
            }


        }
        static void GetAppInfo()
        {
            string AppName = "Number Guesser";
            string version = "1.0.2";
            string Author = "Mannawar";

            //set background color to green for text
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("This App name is {0}!!!\nversion is {1}\nAuthor is {2}", AppName, version, Author);

            //Reset terminal color
            Console.ResetColor();
        }
    }

}

