// Use System
using System;

// Namespace C# "C_Sharp"
namespace C_Sharp
{
    // Class Program "Main"
    class Program
    {
        // Easier printing
        void print(string msg)
        {
            Console.WriteLine(msg);
        }

        bool isYes(string character)
        {
            return ("Y" == character || "y" == character);
        }

        bool isNo(string character)
        {
            return ("N" == character || "n" == character);
        }

        void cls()
        {
            Console.Clear();
        }
        void playGame()
        {
            // Play game
            print("");
        }

        // Setup
        void setup()
        {
            int coins = 0;
        }

        // Main function (void)
        void Main(string[] args)
        {
            // Setup
            setup();

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
