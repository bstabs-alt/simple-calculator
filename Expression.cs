using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Expression
    {
        public Expression(string[] args)
        {

            if ((args[0].Length >= 3) && args.Length == 1)
            {
                string regex = @"[\+\-\*\/]";
                string[] split = Regex.Split(args[0].ToString(), regex);
                MatchCollection op = Regex.Matches(args[0].ToString(), regex);

                LeftHand = Convert.ToDouble(split[0]);
                Operator = op[0].ToString();
                RightHand = Convert.ToDouble(split[1]);

            }
            else if ((args.Length == 3))
            {
                LeftHand = Convert.ToDouble(args[0]);
                Operator = args[1];
                RightHand = Convert.ToDouble(args[2]);
            }
            else
            {
                Console.WriteLine($"{args} is an incorrect expression ");
                Environment.Exit(1);
            }
        }

        public double LeftHand { get; set; }
        public string Operator { get; set; }
        public double RightHand { get; set; }
    }
}
