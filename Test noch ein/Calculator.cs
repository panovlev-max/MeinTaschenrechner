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
                case "*": 
                    return n1 * n2;

                case "/":
                    if (n2 == 0)
                    {
                       throw new DivideByZeroException("Division durch Null ist verboten!");
                    }
                   return n1 / n2;

                case "+":
                    return n1 + n2;

                case "-": 
                    return n1 - n2;
                default:
                    throw new DivideByZeroException("Unbekannter Operator!");
            }
        }

    }
}
