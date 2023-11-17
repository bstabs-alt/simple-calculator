

namespace simple_calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator App!");

            var exp = new Expression(args);

            var calculate = new Calculate(exp);
            var solution = calculate.Solve();

            // Accept two numbers as input.
            // Accept an arithmetic operator (e.g., +, -, *, /) as input.
            // Perform the operation on the two numbers.
            // Handle any potential errors (like division by zero) gracefully.
            // Output the result of the operation.
            Console.WriteLine(" = " + solution.ToString());
        }
    }
}