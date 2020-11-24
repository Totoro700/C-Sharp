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

        // Main function (void)
        static void Main(string[] args)
        {
            // Welcome
            print("Hello!");

            // Ask for name
            print("What\'s your name?");

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
                print("Great!");
            }
            else if (a == "great" || a == "great!")
            {
                print("Awesome!");
            }
            else if (a == "bad")
            {
                print("");
            }
            else if (a == null)
            {
                print("Hmm. We couldn't process your answer!");
            }
            else
            {
                print("Okay then");
            }
        }
    }
}
