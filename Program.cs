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
            print("Hello!");
            print("What\'s your name?");
            string name = Console.ReadLine();
            print("Hello " + name + "!");
            
        }
    }
}
