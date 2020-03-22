using System;

namespace _3zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = "); 
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Первая точка --> ( {x1} ; {y1} )");
            Console.WriteLine($"Вторая точка --> ( {x2} ; {y2} )");
            double p = Math.Abs(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)));
            Console.WriteLine($"Расстояние между двумя точками {p}");
        }
    }
}
