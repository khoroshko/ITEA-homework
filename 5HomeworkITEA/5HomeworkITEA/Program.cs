using System;
using System.Collections.Generic;
using System.Linq;

namespace _5HomeworkITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            dynamic res1 = Calculator.GetCalc("+", 1, 3);
            Console.WriteLine(res1);
            dynamic res2 = Calculator.GetCalc("/", 0, 3);
            Console.WriteLine(res2);

            //2
            List<Car> cars = new List<Car>()
            {
                new Car {CarID=1, Brand ="Honda",Model ="CR-V",Year=2020, Сolor= "Black" },
                new Car {CarID=2, Brand ="Toyota",Model ="Camry",Year=2018, Сolor= "White" },
                new Car {CarID=3, Brand ="Mitsubishi",Model ="Outlander",Year=2018, Сolor= "Grey" }
            };

            List<Client> clients = new List<Client>()
            {
                new Client {ClientID=1, CarID =1,Name ="Ivan",PhoneNumber="+380507863344"},
                new Client {ClientID=2, CarID =1,Name ="Kolya",PhoneNumber="+380679082345"},
                new Client {ClientID=3, CarID =3,Name ="Vasya",PhoneNumber="+380987652398" }
            };

            var query = from client in clients
                        join car in cars on client.CarID equals car.CarID
                        where client.ClientID == 1
                        orderby client.Name
                        select new
                        {
                            id = client.ClientID,
                            name = client.Name,
                            model = car.Brand
                        };

            foreach (var item in query)
            {
                Console.WriteLine(string.Format("ID: {0}, Name: {1}, Model: {2}",
                item.id,
                            item.name,
                            item.model));
            }

            //3
            int[] arr = new int[30];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            Console.WriteLine("ALL");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            var arrItem = from item in arr
                          orderby item
                          group item by item > 0 into partition
                          select new { key = partition.Key, item = partition.FirstOrDefault() };

            Console.WriteLine("First and Last");
            foreach (var item in arrItem)
            {
                Console.WriteLine(item.item);
            }

            //4
            List<FitnessClient> fitnessClient = new List<FitnessClient>()
            {
                new FitnessClient {ClientID=1, Year = 2021, Month = 2, Hour = 8},
                new FitnessClient {ClientID=2, Year = 2021, Month = 7, Hour = 8},
                new FitnessClient {ClientID=3, Year = 2021, Month = 6, Hour = 10}
            };

            string fc =
            fitnessClient.Where(x => x.Hour == fitnessClient.Min(y => y.Hour))
                .Select(x => $"{x.Hour} {x.Year} {x.Month}")
                .Last();

            Console.WriteLine(fc);

            //5
            Dictionary<dynamic, dynamic> DicSky = new Dictionary<dynamic, dynamic>()
            {
                { "дождливо", "rainy" },
                { "солнечно", "sunny" },
                { "пасмурно", "mainly cloudy" },
                { "облачно", "cloudy" },
                { "ветрено", "windy" },
                { "снежно", "snowy" },
                { "холодно", "cold" },
                { "тепло", "warm" },
                { "туманно", "hazy" },
                { "душно", "stuffy" }
            };

            foreach (var item in DicSky)
            {
                Console.Write("{0}={1}", item.Key, item.Value);
                Console.Write("\r\n");
            }


            Console.ReadKey();
        }
    }
}
