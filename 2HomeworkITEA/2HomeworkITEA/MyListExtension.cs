using System;
using System.Collections.Generic;
using System.Text;

namespace _2HomeworkITEA
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] mas = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                mas[i] = list[i];
            }
            return mas;
        }
    }
}
