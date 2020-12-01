using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome," + name);
        }
    }
}
