using System;
using System.Collections.Generic;
using System.Text;

namespace _1HomeworkITEA
{
    public class Book <T>
    {
        private string name;
        private T price;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public T Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public void Show(string Name, T price)
        {
            Console.WriteLine("Book Name: {0} , Book Price: {1}", name, price);
        }

    }
}
