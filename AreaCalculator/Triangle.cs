using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : IFigure
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

        }

        public double CalculateArea()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new Exception("Сторона треугольника не может быть меньше 0");
            }
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool CheckIsRectangular()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new Exception("Сторона треугольника не может быть меньше 0");
            }
            return A * A == B * B + C * C || B * B == A * A + C * C || C * C == B * B + A * A;
        }
    }
}
