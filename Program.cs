using System;

namespace ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y, u;
                Console.WriteLine("Введите значение x");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение y");
                y = double.Parse(Console.ReadLine());
                if (y >= Math.Abs(x))
                {
                    u = Math.Sqrt(Math.Abs(x * x - 1));
                }
                else
                {
                    u = x + y;
                }
                Console.WriteLine($"Значение u = {u}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введён не числовой формат");
            }
        }
    }
}
