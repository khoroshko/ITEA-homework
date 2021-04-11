using System;

namespace _1HomeworkITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book = new Book<int>();
            book.Name = "C#";
            book.Price = 100;
            book.Show(book.Name, book.Price);

            var instance = MyClass<MyType>.FacrotyMethod();
            Console.WriteLine(instance.GetType());

            Calculator calculator = new Calculator();
            double result1 = calculator.Addition<double, string>(2.5, "6");
            Console.WriteLine(result1.ToString());
            double result2 = calculator.Subtraction<int, double>(10, 5.5);
            Console.WriteLine(result2.ToString());
            double result3 = calculator.Multiplication<string, string>("5,6", "1,3");
            Console.WriteLine(result3.ToString());

            Console.ReadKey();
        }
    }
}
