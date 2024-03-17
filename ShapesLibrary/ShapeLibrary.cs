namespace ShapeLibrary
{
    public interface IArea
    {
        double CalculateArea();
    }

    public class Circle : IArea
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius of a circle must be positive.");

            _radius = radius;
        }

        public double CalculateArea() => Math.PI * _radius * _radius;
    }

    public class Triangle : IArea
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Sides of a triangle must be positive.");

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                throw new ArgumentException("Invalid sides for a triangle.");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double p = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public bool IsRectangular()
        {
            double[] sides = [_side1 * _side1, _side2 * _side2, _side3 * _side3];
            Array.Sort(sides);

            return sides[0] + sides[1] == sides[2];
        }
    }

    public class ShapeCalculator
    {
        public static double CalculateArea(IArea area) => area.CalculateArea();
    }
}
