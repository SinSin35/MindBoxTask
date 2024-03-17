using ShapeLibrary;

namespace ShapeLibraryTest
{
    public class CircleTests
    {
        [Fact]
        public void CircleArea()
        {
            double radius = 3.5;
            Circle circle = new Circle(radius);
            
            double expectedResult = Math.PI * radius * radius;
            double result = ShapeCalculator.CalculateArea(circle);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void NegativeRadius()
        {
            double radius = -2;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void TriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Triangle triangle = new Triangle(side1, side2, side3);

            double expectedResult = 6;
            double result = ShapeCalculator.CalculateArea(triangle);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void NegativeSides()
        {
            double side1 = -3;
            double side2 = -4;
            double side3 = -5;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void IsRectangular()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsNotRectangular()
        {
            double side1 = 7;
            double side2 = 8;
            double side3 = 9;

            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.False(triangle.IsRectangular());
        }
    }
}