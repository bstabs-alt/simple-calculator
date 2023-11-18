using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Calculate
    {
        private readonly double LeftHand;
        private readonly string Operator;
        private readonly double RightHand;
        public Calculate(Expression exp)
        {
            LeftHand = exp.LeftHand;
            Operator = exp.Operator;
            RightHand = exp.RightHand;
        }

        public double Solve()
        {
            return Operator switch
            {
                "+" => Add(),
                "-" => Minus(),
                "*" => Multiply(),
                "/" => Divide(),
                _ => SolveEx(),
            };
        }
        private double Add() => LeftHand + RightHand;
        private double Minus() => LeftHand - RightHand;
        private double Multiply() => LeftHand * RightHand;
        private double Divide() => DivideCatch();

        private double DivideCatch()
        {
            try
            {
                return LeftHand / RightHand;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
                Environment.Exit(1);
                return 0;
            }
        }
        public double SolveEx()
        {
            Console.WriteLine("Incorrect Operator Used Exception");
            Environment.Exit(1);
            return 0;
        }
    }
}