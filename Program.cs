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

        static void playGame()
        { 
            // Play game
        }

        static void cls()
        {
            Console.Clear();
        }


        // Main function (void)
        static void Main(string[] args)
        {
            // Welcome
            print("Hello!");

            // Ask for name
            print("What's your name?");

            // Create and store variable
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
                // Check if the user wants to play a game
                print("Do you want to play a game? Y = Yes | N = No ");

                // Create and store variable
                string b = Console.ReadLine();

                // Check
                if (isNo(b))
                {
                    // No
                    print("Okay, then");

                    // Do something else
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
            else if (a == null)
            {
                print("Hmm. We couldn't process your answer!");
            }
            else
            {
                print("Hmm. I hope tommorow is a great day!");
            }
        }
    }
}
