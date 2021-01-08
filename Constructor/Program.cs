using System;
using Faculty;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            facultyClass f1 = new facultyClass("Sapna",29);
            f1.display();
            f1.Name = "Sap";
            f1.display();
            f1.id = 30;
            f1.display();
        }
    }
}
