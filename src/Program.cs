using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n;


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

            Bus[] buses = new Bus[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер маршрута");
                buses[i].NumberRoute = Console.ReadLine();

                Console.WriteLine("Введите первую конечную остановку");
                buses[i].EndStop1 = Console.ReadLine();

                Console.WriteLine("Введите вторую конечную остановку");
                buses[i].EndStop2 = Console.ReadLine();

                Console.WriteLine("Введите количество остановок");
                while (true)
                {
                    try
                    {
                        buses[i].CountStop = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введите целое число");
                    }
                }
            }
        }
    }
}
