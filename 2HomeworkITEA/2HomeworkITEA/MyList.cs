using System;
using System.Collections.Generic;
using System.Text;

namespace _2HomeworkITEA
{
    public class MyList<T>: IMyList<T>
    {
        private T[] array;
        private int count;

        public MyList()
        {
            array = new T[0];
        }


        public T this[int index]            
        {
            get
            {
                if (index <= array.Length)
                    return array[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index <= array.Length)
                    array[index] = (T)value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public int Count                   
        {
            get
            {
                return count;
            }
        }


        public void Add(T a)
        {
            T[] new_myList = new T[array.Length + 1];
            array.CopyTo(new_myList, 0);
            new_myList[new_myList.Length-1] = a;
            array = new_myList;
            count = count + 1;
        }

        public void Clear()
        {
            T[] array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            { 
                if ((object)array[i] == (object)item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
