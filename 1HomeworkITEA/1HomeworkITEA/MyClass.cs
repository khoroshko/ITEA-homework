using System;
using System.Collections.Generic;
using System.Text;

namespace _1HomeworkITEA
{
    public class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
