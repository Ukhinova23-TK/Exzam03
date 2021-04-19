using System;

namespace src
{
    class Program
    {
        private static int n;
        private static Bus[] buses;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");

            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите целое число");
                }
            }

            buses = new Bus[n];
            EnterBuses();
            PrintBuses();
            Console.ReadLine();
        }

        static private void EnterBuses()
        {

            for (int i = 0; i < n; i++)
            {
                buses[i] = new Bus();

                Console.WriteLine("Введите номер маршрута");
                string number = (Console.ReadLine());
                while (string.IsNullOrEmpty(number))
                {
                    Console.WriteLine("Введите номер маршрута");
                    number = (Console.ReadLine());
                }
                buses[i].NumberRoute = number;

                Console.WriteLine("Введите первую конечную остановку");
                string end1 = (Console.ReadLine());
                while (string.IsNullOrEmpty(end1))
                {
                    Console.WriteLine("Введите первую конечную остановкуа");
                    end1 = (Console.ReadLine());
                }
                buses[i].EndStop1 = end1;

                Console.WriteLine("Введите вторую конечную остановку");
                string end2 = (Console.ReadLine());
                while (string.IsNullOrEmpty(end2))
                {
                    Console.WriteLine("Введите вторую конечную остановкуа");
                    end2 = (Console.ReadLine());
                }
                buses[i].EndStop2 = end2;

                Console.WriteLine("Введите количество остановок");
                int count;
                while (true)
                {
                    try
                    {
                        count = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введите целое число");
                    }
                }
                buses[i].CountStop = count;
            }
        }

        //static private void PrintBuses()
        //{
        //    for(int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine($"\nНомер маршрута: {0}" +
        //        $"\nПервая конечная остановка: {1}" +
        //        $"\nВторая конечная остановка: {2}" +
        //        $"\nКоличество остановок: {3}",
        //        buses[i].NumberRoute,
        //        buses[i].EndStop1,
        //        buses[i].EndStop2,
        //        buses[i].CountStop);
        //    }
        //}
    }
}
