using System;

namespace Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else statement
            Console.WriteLine("If else statement");
            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            Console.WriteLine("Resident of the place");
            string resident = Console.ReadLine();
            if(Convert.ToInt32(age) >= 18 && resident=="true")
            {
                Console.WriteLine("Allowed to vote");
            } else if (Convert.ToInt32(age) >= 18 && resident == "false")
            {
                Console.WriteLine("Not a resident of the place");
            } else if (Convert.ToInt32(age) < 18 && resident == "true")
            {
                Console.WriteLine("Age below 18");
            } else
            {
                Console.WriteLine("Not allowed to vote");
            }

            // ternary operator
            Console.WriteLine("Ternary Operator");
            string result = Convert.ToInt32(age) >= 18 ? "Age above or equal to 18": "Age below 18";
            Console.WriteLine(result);

            // continue
            Console.WriteLine("Continue");
            Console.WriteLine("Print Even number from 0 to 10");
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);
            }

            // break
            Console.WriteLine("Break");
            Console.WriteLine("Print Even number from 1 to 5");
            int counter = 1;
            while (true)
            {
                Console.WriteLine(counter++);
                if (counter>5)
                    break;
            }

            // nested loop
            Console.WriteLine("Nested Loop break");
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (j == i) break;
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            // switch
            Console.WriteLine("switch");
            switch (Convert.ToInt32(age)) {
                case 18 :
                    Console.WriteLine("Age equal to 18");
                    break;
                default:
                    Console.WriteLine("Age not equal to 18");
                    break;
            }

            //nested condition using ternary operator
            Console.WriteLine("Nested condition using ternary operator");
            int a = 3;
            int b = -5;
            int c = -7;

            int largest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
            Console.WriteLine("Largest:" + largest);

            // nested loop 
            Console.WriteLine("Nested Loop");
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            // while 
            Console.WriteLine("While");
            int num = 5;
            while (num > 0)
            {
                Console.Write(num+" ");
                num--;
            }
            Console.WriteLine();

            // do while
            Console.WriteLine("Do while");
            do
            {
                num++;
                Console.Write(num + " ");
            } while (num > 5);
            Console.WriteLine();

            Console.WriteLine("Enter month number");
            string month = Console.ReadLine();
            int monthNumber = Convert.ToInt32(month);

            // no: of days in a month using if else
            Console.WriteLine("Using if-else");
            if (monthNumber<0 || monthNumber>12)
                Console.WriteLine("Enter Valid number");
            else if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
                Console.WriteLine("31 Days");
            else if (monthNumber == 2)
                Console.WriteLine("28/29 Days");
            else
                Console.WriteLine("30 Days");

            // no: of days in a month using switch
            Console.WriteLine("Using Switch");
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("31 Days");
                    break;
                case 2:
                    Console.Write("28/29 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("30 Days");
                    break;
                default:
                    Console.Write("Enter a Valid number");
                    break;
            }
        }
    }
}
