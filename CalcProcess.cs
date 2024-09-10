using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalcProcess
    {
        private double num1;
        private double num2;

        public CalcProcess(double Num1, double Num2)
        {
            num1 = Num1;
            num2 = Num2;
        }

        public double Sum()
        {
            return num1 + num2;
        }

        public double Sub()
        {
            return num1 - num2;
        }

        public double Multi()
        {
            return num1 * num2;
        }

        public double Div()
        {
            return num1 / num2;
        }

        public double Mod()
        {
            return num1 % num2;
        }
    }
}
