using System;

namespace _3HomeworkITEA
{
    class Program
    {
        //1
        delegate int MyDelegate(int a, int b, int c);

        //2
        delegate int OperationDelegat(int a, int b);

        //3
        public delegate int Number();
        public delegate int MediumCalc(Number[] arrayX);


        static void Main(string[] args)
        {

            //1
            MyDelegate myDelegate = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };
            int res = myDelegate(1, 3, 5);

            //2
            Console.WriteLine("Введите действие--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Первое число -->");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число -->");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    OperationDelegat myDelegat = (c, b) => c + b;
                    int del = myDelegat(x, y);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    OperationDelegat myDelegat1 = (c, b) => c - b;
                    int del1 = myDelegat1(x, y);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    OperationDelegat myDelegat2 = (c, b) => c * b;
                    int del2 = myDelegat2(x, y);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    OperationDelegat myDelegat3 = (c, b) => b == 0 ? 0 : c / b;
                    int del3 = myDelegat3(x, y);
                    Console.WriteLine("Ответ:{0}", del3);
                    break;
            }

            //3

            Number[] numArr = new Number[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer;
                Console.Write(" " + numArr[i].Invoke() + " ");
            }
            Console.WriteLine();

            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return ((sum) / (arrayX.Length));
            };


            Console.Read();
        }

        //3
        public static int Randomizer()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }
    }
}
