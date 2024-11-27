using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Х0");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y1");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y2");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double lenght = Circle.GetLength(r);
            double square = Circle.GetSquare(r);
            string coordinates = Circle.GetCoordinates(r, x0, x1, y0, y1);
            Console.WriteLine($"Длина окружности: {lenght}");
            Console.WriteLine($"Площадь окружности равна {square}");
            Console.WriteLine($"Координаты {coordinates}");
            Console.ReadKey();
        }
    }
}
