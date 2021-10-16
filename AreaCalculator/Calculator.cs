using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
   public class Calculator
    {
        static public double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
