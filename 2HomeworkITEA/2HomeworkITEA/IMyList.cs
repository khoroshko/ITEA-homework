using System;
using System.Collections.Generic;
using System.Text;

namespace _2HomeworkITEA
{
    interface IMyList<T>
    {
        T this[int index] { get; }
        int Count { get; }
        void Add(T a);
        void Clear();
        bool Contains(T item);
    }
}
