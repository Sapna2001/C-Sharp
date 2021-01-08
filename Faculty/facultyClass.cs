using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty
{
    public class facultyClass
    {
        public string name;
        public int id;
        public facultyClass(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
    }
}
