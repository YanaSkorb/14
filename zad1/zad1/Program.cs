using System;
using System.Threading;

namespace zad1
{
    internal class Program
    {
        static void potok1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 1 выводит: " + i);
            }
        }

        static void potok2()
        {

            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine("Поток 2 выводит: " + i);
            }
        }

        static void potok3()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine("Поток 3 выводит: " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(potok1);
            Thread thread2 = new Thread(potok2);
            Thread thread3 = new Thread(potok3);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread3.Priority = ThreadPriority.Lowest;

            thread1.Start();
            Thread.Sleep(1000);
            thread2.Start();
            Thread.Sleep(1000);
            thread3.Start();

            Console.ReadLine();
        }
    }
}
