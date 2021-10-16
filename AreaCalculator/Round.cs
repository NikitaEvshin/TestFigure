using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Round : IFigure
    {
        public int Radius;

        public Round(int radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            if (Radius <= 0)
            {
                throw new Exception("Радиус не может быть меньше или равен 0");
            }
            return Math.PI * 2 * Radius;
        }
    }
}

