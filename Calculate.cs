using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_calculator
{

    public class Calculate
    {
        private int lh;
        private int rh;

        public Calculate(int lh, int rh)
        {
            this.lh = lh;
            this.rh = rh;
        }

        public int Add()
        {
            return lh + rh;
        }

        public int Minus()
        {
            return lh - rh;
        }

        public int Multiply()
        {
            var multiplied = 0;
            for(int i = 0; i <= lh-1; i++){
                multiplied += rh;
            }
            return multiplied;
        }

        public int Divide(){
            // var divided = lh - rh;
            // for(int i = 0; i <= lh-1; i++){
            //     value ();
            // }
            // return divided;
            return lh / rh;
        }
    }
}