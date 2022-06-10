using System;
using System.Diagnostics;
using System.Threading;

namespace zad2
{
    internal class Program
    {
        static void potok1()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Console.WriteLine("Поток 1 выводит: " + sum);
            }
        }
        static void potok2()
        {
            int sum1 = 0;
            for (int i = 0; i < 10; i++)
            {
                sum1 += i;
                Console.WriteLine("Поток 2 выводит: " + sum1);
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            Thread thread1 = new Thread(potok1);
            Thread thread2 = new Thread(potok2);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;

            sWatch.Start();
            thread1.Start();
            Thread.Sleep(1000);
            sWatch.Stop();
            thread2.Start();

            Console.WriteLine("Время (в мс.) затраченное на первый поток = " + sWatch.ElapsedMilliseconds.ToString());
            Console.ReadLine(); 
        }
    }
}