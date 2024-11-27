using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLength(double r)
        { 
        return 2*Math.PI*r;
        }

        static public double GetSquare(double r)
        {
            return Math.PI * (r * r);
        }

        static public string GetCoordinates(double r, double x0, double x1, double y0, double y1)
        {
            if (Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2)) <= r)
                return "принадлежат окружности";
            else
                return "не принадлежат окружности";

        }







    }
}
