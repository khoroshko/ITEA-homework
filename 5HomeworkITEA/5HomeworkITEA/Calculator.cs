using System;
using System.Collections.Generic;
using System.Text;

namespace _5HomeworkITEA
{
    public class Calculator
    {
        public static dynamic GetCalc(dynamic sign, dynamic numeral1, dynamic numeral2)
        {
            dynamic res = 0;
            switch (sign)
            {
                case "+":
                    res = numeral1 + numeral2;
                    break;
                case "-":
                    res = numeral1 - numeral2;
                    break;
                case "*":
                    res = numeral1 * numeral2;
                    break;
                case "/":
                    if (numeral1 != 0)
                    {
                        res = numeral1 / numeral2;
                    }
                    else
                    {
                        res = "Деление на ноль невозможно";
                    }
                    break;
                default:
                    res = "Неизвестный символ";
                    break;

            }
            return res;
        }
    }
}
