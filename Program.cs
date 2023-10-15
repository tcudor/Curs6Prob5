namespace Curs6Prob5
{
        class Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        class Triangle
        {
            public Point PointA { get; }
            public Point PointB { get; }
            public Point PointC { get; }

            public Triangle(Point a, Point b, Point c)
            {
                PointA = a;
                PointB = b;
                PointC = c;
            }

            public double CalculatePerimeter()
            {
                double sideAB = CalculateDistance(PointA, PointB);
                double sideBC = CalculateDistance(PointB, PointC);
                double sideCA = CalculateDistance(PointC, PointA);

                return sideAB + sideBC + sideCA;
            }

            public double CalculateArea()
            {
                double sideAB = CalculateDistance(PointA, PointB);
                double sideBC = CalculateDistance(PointB, PointC);
                double sideCA = CalculateDistance(PointC, PointA);

                double s = CalculatePerimeter() / 2;
                return Math.Sqrt(s * (s - sideAB) * (s - sideBC) * (s - sideCA));
            }

            private double CalculateDistance(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            }
        }

        class Rectangle
        {
            public Point UpperLeftCorner { get; }
            public double Width { get; }
            public double Height { get; }

            public Rectangle(Point upperLeft, double width, double height)
            {
                UpperLeftCorner = upperLeft;
                Width = width;
                Height = height;
            }

            public double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }

            public double CalculateArea()
            {
                return Width * Height;
            }
        }

        class Square
        {
            public Point UpperLeftCorner { get; }
            public double SideLength { get; }

            public Square(Point upperLeft, double sideLength)
            {
                UpperLeftCorner = upperLeft;
                SideLength = sideLength;
            }

            public double CalculatePerimeter()
            {
                return 4 * SideLength;
            }

            public double CalculateArea()
            {
                return Math.Pow(SideLength, 2);
            }
        }

    class Program
    {
        static void Main()
        {
            Point pointA = new Point(0, 0);
            Point pointB = new Point(3, 0);
            Point pointC = new Point(0, 4);

            Triangle triangle = new Triangle(pointA, pointB, pointC);
            Console.WriteLine("Triunghi:");
            Console.WriteLine($"Perimetru: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Arie: {triangle.CalculateArea()}\n");

            Point upperLeft = new Point(1, 1);
            Rectangle rectangle = new Rectangle(upperLeft, 5, 3);
            Console.WriteLine("Dreptunghi:");
            Console.WriteLine($"Perimetru: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Arie: {rectangle.CalculateArea()}\n");

            Point squareUpperLeft = new Point(2, 2);
            Square square = new Square(squareUpperLeft, 4);
            Console.WriteLine("Patrat:");
            Console.WriteLine($"Perimetru: {square.CalculatePerimeter()}");
            Console.WriteLine($"Arie: {square.CalculateArea()}");
        }
    }
}