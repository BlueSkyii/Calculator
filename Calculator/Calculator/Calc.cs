using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        private double num1;
        private double num2;

        public Calc(double x,double y) { 
            num1 = x; 
            num2 = y;
        }

        public double Sum() { 
            return num1 + num2;
        }

        public double Sub() { 
            return num1 - num2;
        }

        public double Mult() {
            return num1 * num2;
        }

        public double Div() {
            return num1 / num2;
        }

        public double Mod() { 
            return num1 % num2;
        }
    }
}
