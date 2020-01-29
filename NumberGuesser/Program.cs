using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class MainClass
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            //string name = "TaneriMan";
            //int age = 32;

            ////Console class for opening console and operating processes on console
            //Console.WriteLine("Hello World");

            ////after write there is no empty line
            //Console.Write("Hello World"); 
            //Console.WriteLine(name);
            //Console.WriteLine("Hello " + name + " is " + age);

            ////Dynamic Variables
            //Console.WriteLine("{0} is {1}", name, age);

            //Run get app info function to get info
            GetApplicationInfo();

            //Ask user name and greeting
            GreetingUser();



            while (true)
            {
                ////Set correct number
                //int correctNumber = 7;

                //Create new Random Number
                Random random = new Random();
                //Create a Random Number Between 1 and 10
                int correctNumber = random.Next(1, 10);

                //Init guessing Number
                int guess = 0;

                //Ask user for Number
                Console.WriteLine("Guess a number between 1 and 10");

                //While loop for until correct number
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make Sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change print color to red and print error message
                        ChangePrintColor(ConsoleColor.Red, "It is not an actual number!!!");

                        //Continue
                        continue;
                    }

                    //convert string to int
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change print color to red and print error message
                        ChangePrintColor(ConsoleColor.Red, "Wrong number! Please try again");
                    }
                }

                //Change print color to green and print congratulation message
                ChangePrintColor(ConsoleColor.Green, "You are Correct!!!");

                ////Ask to user play again? Change print color to yellow
                ChangePrintColor(ConsoleColor.Yellow, "Do you want to play again? [Y or N]");

                //Get answer
                //Answer is took as uppercase
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Give app info method
        static void GetApplicationInfo()
        {

            // Set Number Guesser Application Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "TaneriMan";

            // Change Text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();

            ////Write out app info
            //Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        }

        //Take user name and greet
        static void GreetingUser()
        {
            // Change Text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Ask Users name
            Console.WriteLine("What is your name?");

            //Reading user name
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            //Reset Text Color
            Console.ResetColor();

        }

        //Change print color
        static void ChangePrintColor( ConsoleColor consoleColor, string message)
        {
            Console.ForegroundColor = consoleColor;

            //Tell user that is not a number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }


    }
}
