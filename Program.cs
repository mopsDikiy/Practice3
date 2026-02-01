using System;
namespace Practice3
{ 
    class Program
    { 
        static void Main()
        {
            Console.WriteLine("Введите n");
            uint n, i = 1;
            n = Convert.ToUInt32(Console.ReadLine());
            double p = 0;
            for (; i <= n; i++)
            {
                p += Math.Pow(i, 7);
            }
            Console.WriteLine("Для n = {0}", n);
            Console.WriteLine("Результат = {0:f0}", p);
        }
    }
}
