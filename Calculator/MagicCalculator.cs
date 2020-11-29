using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class MagicCalculator 
    {
        public int number1, number2, noOfOperands;
        public string op;

        public MagicCalculator(int number1, string op)
        {
            this.number1 = number1;
            this.op = op;
        }

        public MagicCalculator(int number1, int number2, string op)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.op = op;
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
                case "max":
                    return Math.Max(number1,number2);
                case "min":
                    return Math.Min(number1, number2);
                case "sqrt":
                    return (int) Math.Sqrt(number1);
                case "abs":
                    return Math.Abs(number1);
                case "sin":
                    return (int)Math.Sin(number1);
                case "cos":
                    return (int)Math.Cos(number1);
                case "tan":
                    return (int)Math.Tan(number1);
                default:
                    Console.WriteLine("Invalid Operation");
                    return -1;
            }
        }
    }
}
