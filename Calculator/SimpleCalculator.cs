using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class SimpleCalculator
    {
        public int number1, number2;
        public string op;

        public SimpleCalculator(int number1, int number2, string op)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.op= op;
        }
        public int calculate()
        {
            switch (op)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    Console.WriteLine("Invalid Operation");
                    return -1;
            }
        }
    }
}
