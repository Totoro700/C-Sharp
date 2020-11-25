// Use System
using System;

// Namespace C# "C_Sharp"
namespace C_Sharp
{
    // Class Program "Main"
    class Program
    {
        // Easier printing
        static void print(string msg)
        {
            Console.WriteLine(msg);
        }

        static bool isYes(string character)
        {
            return ("Y" == character || "y" == character);
        }

        static bool isNo(string character)
        {
            return ("N" == character || "n" == character);
        }

        static void cls()
        {
            Console.Clear();
        }

        // Setup
        static void setup()
        {
            // Clear
            cls();
        }

        // Play game
        static void playGame()
        {
            // Play game
            print("");

            // Declare variable
            int coins = 0;

            // Instructions
            print("You have " + coins + " coins to start with");
            print("To get coins, you have to join two numbers");

            // Declare variable (random)
            var ran = new Random();

            // Forever loop (null == null)
            while (null == null)
            {
                // Declare variables
                double numOne = ran.NextDouble() * 5;
                double numTwo = ran.NextDouble() * 5;

                // Final value as a string
                // Combine (not add) the two random numbers
                string finalValue = numOne.ToString() + numTwo.ToString();

                // Declare user input variable as assign it to null
                string userInput = null;

                // Use Console.Write for only one line
                Console.Write("Join ");

                // Use Console.WriteLine because data type double can not be converted to string
                Console.Write(numOne);

                Console.Write(" and ");
                Console.Write(numTwo);

                // Add new line
                print("");

                // Get input
                userInput = Console.ReadLine();

                Console.WriteLine(numOne);
                Console.WriteLine(numTwo);
                Console.WriteLine(finalValue);

                // Check if correct
                if (userInput == finalValue)
                {
                    print("Correct!");
                    coins++;
                    print("You now have " + coins + " coin(s)!");
                    print("-------------------------------------------------");
                }
                else
                {
                    print("Sorry, that was incorrect");
                    print("-------------------------------------------------");
                }
            }
        }

        // Main function (void)
        static void Main(string[] args)
        {
            // Setup
            setup();

            // Welcome
            print("Hello!");

            // Ask for name
            print("What's your name?");

            // Declare and store variable
            string name = Console.ReadLine();
            print("Hello " + name + "!");
            print("How are you?");

            // Create and store variable
            string a = Console.ReadLine();

            // Lower chars
            a = a.ToLower();

            // Check
            if (a == "good" || a == "good!")
            {
                // Good
                print("Great!");
            }
            else if (a == "great" || a == "great!")
            {
                // Great
                print("Awesome!");
            }
            else if (a == "bad")
            {
                // Bad
                print("We hope that tomorrow is a better day!");
            }
            else if (a == null)
            {
                print("Hmm. We couldn't process your answer!");
            }
            else
            {
                print("Hmm. I hope tommorow is a great day!");
            }

            // Check if the user wants to play a game
            print("Do you want to play a game? Y = Yes | N = No ");

            // Create and store variable
            string b = Console.ReadLine();

            // Check
            if (isNo(b))
            {
                // No
                print("Okay, no problem");
            }
            else if (isYes(b))
            {
                // Yes
                print("Playing a game . . .");

                // Play game
                playGame();
            }
            else if (b == null)
            {
                // Null
                print("We couldn't process process your answer!");
            }
            else
            {
                print("That is not a valid answer!");
            }
        }
    }
}
