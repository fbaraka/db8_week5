using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        // a constructor that takes an int that stores it in a int property num.
        // A method called CalcFactorial that returns the factorial as an integer
        // 

        public int Number { get; set; }

        public Calculator(int _Number)
        {
            Number = _Number;
        }
        public int FindFactorial()
        {

            int result = Number;

            for (int i = Number - 1; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        public List<int> FindFactors()
        {
            List<int> result = new List<int>();

            return result;
        }

    }
}
