using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2HomeworkITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("1-----------");
            MyList<int> ml = new MyList<int>();

            for (int i = 0; i < 20; i++)
            {
                ml.Add(i + 1);
            }

            for (int i = 0; i < ml.Count; i++)
            {
                Console.WriteLine(ml[i]);
            }

            Console.WriteLine("2-----------");

            //2
            int[] myMas = MyListExtension.GetArray(ml);

            for (int i = 0; i < myMas.Length; i++)
            {
                Console.WriteLine(myMas[i]);
            }

            Console.WriteLine("3-----------");

            //3
            var dic1 = new SortedDictionary<string, int>()
                {{"a", 300}, {"b", 200}, {"c", 100}};
            foreach (var kvp in dic1)
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);

            Console.WriteLine("-----------");

            var dic2 = new SortedDictionary<string, int>(new FooComparer())
                {{"a", 300}, {"b", 200}, {"c", 100}};
            foreach (var kvp in dic2)
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            Console.ReadKey();
        }
    }

    class FooComparer : IComparer<string>
    {
        public int Compare(string foo1, string foo2)
        {
            return String.Compare(foo2, foo1, true, CultureInfo.InvariantCulture);
        }
    }
}
