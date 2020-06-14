using System;

namespace ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, u;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y >= Math.Abs(x))
            {
                u = Math.Sqrt(Math.Abs(x * x - 1));
            }
            else
            {
                u = x + y;
            }
            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
}
