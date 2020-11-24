using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What\'s your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
