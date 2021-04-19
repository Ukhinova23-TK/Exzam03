using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SortBuses();
            PrintBuses();
            SaveFile();
            Console.ReadLine();
        }

        static public void EnterBuses()
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

        static public void SortBuses()
        {
            buses = buses.AsQueryable<Bus>().OrderByDescending(bus => bus.CountStop).ThenByDescending(bus => bus.NumberRoute).ToArray();
        }

        static public void PrintBuses()
        {
            foreach (Bus bus in buses)
            {
                Console.WriteLine($"\nНомер маршрута: {bus.NumberRoute} " +
                    $"\nПервая конечная остановка: {bus.EndStop1} " +
                    $"\nВторая конечная остановка: {bus.EndStop2} " +
                    $"\nКоличество остановок: {bus.CountStop}");
            }
        }

        static public void SaveFile()
        {
            using (StreamWriter sw = new StreamWriter("buses.txt"))
            {
                foreach (Bus bus in buses)
                {
                    sw.WriteLine(bus.NumberRoute + "<teg> " 
                        + bus.EndStop1 + "<teg> " 
                        + bus.EndStop2 + "<teg> " 
                        + bus.CountStop + "<teg> ");
                }
            }
        }
    }
}
