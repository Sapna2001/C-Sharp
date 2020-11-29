using System;

namespace Calculator
{
    class Program
    {
        /*
         variables used:
         option - To select the type of calculator (1:basic, 2: Magic)
         noOfOperands - To select the no of operands (1/2)
         numberOne - number for 1 operand
         opOne - operator for 1 operand
         answerOne - answer for 1 operand
         number1Two - number1 for 2 operand
         number2Two - number2 for 2 operand
         opTwo - operator for 2 operand
         answer1Two - answer for 2 operator and Basic type
         answer2Two - answer for 2 operator and Magic type
         breakStatement - break the loop
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            bool status =true;
            while (status)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Basic Calculator");
                Console.WriteLine("2. Magic Calculator");
                Console.WriteLine("Enter choice:");
                string option = Console.ReadLine();
                Console.WriteLine("Enter no:of operands (1/2):");
                string noOfOperands = Console.ReadLine();
                switch (Convert.ToInt32(noOfOperands))
                {
                    case 1:
                        Console.WriteLine("Enter Number1:");
                        String numberOne = Console.ReadLine();
                        Console.WriteLine("Enter Operator:");
                        String opOne = Console.ReadLine();
                        MagicCalculator calcOne = new MagicCalculator(Convert.ToInt32(numberOne), opOne);
                        int answerOne = calcOne.calculate();
                        Console.WriteLine("Answer="+answerOne);
                        break;
                    case 2:
                        Console.WriteLine("Enter Number1:");
                        String number1Two = Console.ReadLine();
                        Console.WriteLine("Enter Number2:");
                        String number2Two = Console.ReadLine();
                        Console.WriteLine("Enter Operator:");
                        String opTwo = Console.ReadLine();
                        if (option == "1")
                        {
                            SimpleCalculator calc1Two = new SimpleCalculator(Convert.ToInt32(number1Two), Convert.ToInt32(number2Two), opTwo);
                            int answer1Two = calc1Two.calculate();
                            Console.WriteLine("Answer="+answer1Two);
                        }
                        if (option == "2")
                        {
                            MagicCalculator calc1Two = new MagicCalculator(Convert.ToInt32(number1Two), Convert.ToInt32(number2Two), opTwo);
                            int answer2Two = calc1Two.calculate();
                            Console.WriteLine("Answer="+answer2Two);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Select 0 to break else press any key");
                string breakStatement = Console.ReadLine();
                status = (breakStatement == "0") ? false : true;
            }
        }
    }
}
