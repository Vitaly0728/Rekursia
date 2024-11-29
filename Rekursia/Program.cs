using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Rekursia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
//Цикл
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Сycle(5)}");
            stopWatch.Stop();
            Console.WriteLine($"Время нахождения 5-го значения = {stopWatch.ElapsedMilliseconds}\n");

            
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Сycle(10)}");
            stopWatch.Stop();
            Console.WriteLine($"Время нахождения 10-го значения = {stopWatch.ElapsedMilliseconds}\n");

            
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Сycle(20)}");
            stopWatch.Stop();
            Console.WriteLine($"Время нахождения 20-го значения = {stopWatch.ElapsedMilliseconds}\n");

// Рекурсия
            
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Rekursia(5)}");
            stopWatch.Stop();
            Console.WriteLine($"Время нахождения 5-го значения = {stopWatch.ElapsedMilliseconds}\n");

            
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Rekursia(10)}");
            stopWatch.Stop();
            
            Console.WriteLine($"Время нахождения 10-го значения = {stopWatch.ElapsedMilliseconds} \n");

            
            stopWatch.Start();
            Console.WriteLine($"Итеративный метод: {Rekursia(20)}");
            stopWatch.Stop();
            Console.WriteLine($"Время нахождения 20-го значения = {stopWatch.ElapsedMilliseconds}\n");
        }
        public static int Сycle(int a)
        {
            int first = 0;
            int second = 1;
            int next = 0;

            while (a > 0)
            {
                next = first + second;
                second = first;
                first = next;
                
                a--;                
            }
            return next;
        }
        
        public static int Rekursia(int a)
        {
            if (a <= 1)
                return a;

            return Rekursia(a - 1) + Rekursia(a - 2);
        }
    }
}
