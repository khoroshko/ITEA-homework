using System;
using System.Collections.Generic;
using System.Text;

namespace _1HomeworkITEA
{
    public class Calculator
    {

        public double Addition<T1,T2>(T1 value1, T2 value2)
        {
            double dValue1 = Convert.ToDouble(value1);
            double dValue2 = Convert.ToDouble(value2);
            double sum = dValue1 + dValue2;
            return sum;
        }

        public double Subtraction<T1, T2>(T1 value1, T2 value2)
        {
            double dValue1 = Convert.ToDouble(value1);
            double dValue2 = Convert.ToDouble(value2);
            double sum = dValue1 - dValue2;
            return sum;
        }

        public double Multiplication<T1, T2>(T1 value1, T2 value2)
        {
            double dValue1 = Convert.ToDouble(value1);
            double dValue2 = Convert.ToDouble(value2);
            double sum = dValue1 * dValue2;
            return sum;
        }
    }
}
