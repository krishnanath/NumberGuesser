using System;


// NameSpace 

namespace NumberGusser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)

        {

            GetAppInfo();

            //Ask users name
            Console.WriteLine("What is your name?");
            //Get users input
            string inputName = Console.ReadLine();

            //

            Console.WriteLine("Hello {0} , Let's play a game...", inputName);

            //Set correct umber
            //int correctNumber = 7;

            while (true)

            {


                //Create a new Random Object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input

                    string input = Console.ReadLine();

                    //Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter an actual number");
                        Console.ResetColor();

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number

                    if (guess != correctNumber)
                    {

                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, please try again");

                        //Reset text Color
                        Console.ResetColor();


                    }


                }

                Console.ForegroundColor = ConsoleColor.Green;

                //Tell user its the  right number
                Console.WriteLine("Congratulations " + inputName + " You guessed right number");

                //Reset Text color
                Console.ResetColor();

                //Play Again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y"){
                    continue;
                }
                else if (answer == "N") {
                    return;
                    
                }
                else
                {
                    return;
                }
            }



        }



        static void GetAppInfo(){

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.1.1";
            string appAuthor = " Krishnanath ";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text Color
            //Console.ResetColor();
            
        }
    }
}
