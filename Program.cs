
using System.ComponentModel;
using System;
namespace simple_calculator
{
    public class CalculatorBase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator App!");

            while(true){
                Console.Write("no 1:");
                var lh = Convert.ToInt32(Console.ReadLine());

                Console.Write("no 2:");
                var rh = Convert.ToInt32(Console.ReadLine());

                Console.Write("sign :");
                var sign = Console.ReadLine();

                Calculate calc = new(lh, rh);

                var output = 0;
                switch (sign)
                {
                    case "+":
                        output = calc.Add();
                        break;
                    case "-":
                        output = calc.Minus();
                        break;
                    case "*":
                        output = calc.Multiply();
                    case "/":
                        output = calc.Divide();
                        break;
                    default:
                        output (string) = "error could not calculate!";
                        break;
                }
                // Accept two numbers as input.
                // Accept an arithmetic operator (e.g., +, -, *, /) as input.
                // Perform the operation on the two numbers.
                // Handle any potential errors (like division by zero) gracefully.
                // Output the result of the operation.
                Console.WriteLine("output: " + output);
            }
        }
    }
}