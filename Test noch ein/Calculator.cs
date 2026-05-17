using System;
using System.Collections.Generic;
using System.Text;

namespace Test_noch_ein
{
 public class Calculator
    {
        public double Berechne(double n1, double n2, string op)
        {

            switch (op)
            {
                case "*": return n1 * n2;
                case "/": return n2 != 0 ? n1 / n2 : 0;
                case "+": return n1 + n2;
                case "-": return n1 - n2;
                default: return 0;
            }
        }

    }
}
