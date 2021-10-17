using AreaCalculator;
using System;
using Xunit;

namespace AreaCalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckErrorIfRadiusLessThanZero()
        {
            Round round = new Round(-6);
            Assert.Throws<Exception>(() => Calculator.CalculateArea(round));

        }

        [Fact]
        public void CheckAreaIsCorrect()
        {
            Round round = new Round(10);
            double area = Math.PI * 2 * 10;
            double result = Calculator.CalculateArea(round);
            Assert.Equal(area, result);
        }

        [Fact]
        public void CheckSideIsCorrect()
        {
            Triangle triangle = new Triangle(3, 2, 5);
            double p = (3 + 2 + 5) / 2;
            double area = Math.Sqrt(p * (p - 3) * (p - 2) * (p - 5));
            double result = Calculator.CalculateArea(triangle);
            Assert.Equal(area, result);
        }

        [Fact]
        public void CheckErrorIfSideLessThanZero()
        {
            Triangle triangle = new Triangle(3, 2, -1);
            Assert.Throws<Exception>(() => Calculator.CalculateArea(triangle));
        }
        [Fact]
        public void CheckTriangleIsRectangular()
        {
            Triangle triangle = new Triangle(4, 3, -5);
            Assert.Throws<Exception>(() => triangle.CheckIsRectangular());
        }
    }
}
