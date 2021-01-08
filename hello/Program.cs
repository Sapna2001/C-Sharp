using System;

namespace hello
{
    class Program
    {
        public string name;
        public int id;

        Program(string name, int id)
        {
            this.name = name;
            this.id = id;
            Console.WriteLine("Constructor");
        }

        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
        
    }
}
