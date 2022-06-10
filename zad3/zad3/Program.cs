using System;
using System.Threading;

namespace zad3
{
    internal class Program
    {
        static void FirstMethod(int a)
        {
            double sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum = sum + Math.Pow(a, i);
                Console.WriteLine($"Первый метод: {sum}");
            }
        }
        static void SecondMethod(double a)
        {
            double multiply = 1;
            for (int j = 1; j < 10; j++)
            {
                multiply = multiply * Math.Pow(a, j);
                Console.WriteLine($"Второй метод: {multiply}");
            }
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());
            int n;
            Console.Write("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Thread thread1 = new Thread(() => FirstMethod(a));
            Thread thread2 = new Thread(() => SecondMethod(n));
            Thread thread3 = new Thread(() => FirstMethod(a));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();
        }

    }
}