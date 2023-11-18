

namespace simple_calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var exp = new Expression(args);
            var calculate = new Calculate(exp);
            var solution = calculate.Solve();

            Console.Write(exp.LeftHand + " " + exp.Operator + " " + exp.RightHand + " = " + solution);
        }
    }
}