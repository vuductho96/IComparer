using System;
using System.Collections.Generic;

namespace ShapeClass
{
    public class Shape
    {
        public string Color { get; set; }
        public bool Filled { get; set; }
        public Shape()
        {
            Color = "Green";
            Filled = true;
        }
        public string Tostring()
        {
            return $"A Shape with color of {Color} and filled {(Filled ? "filled" : "not filled")}";
        }
    }



    public class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x.Getarea() > y.Getarea())
            {
                return 1;
            }
            else if (x.Getarea() < y.Getarea())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }


    namespace ShapeClass
    {
        public class Shape
        {
            public string Color { get; set; }
            public bool Filled { get; set; }
            public Shape()
            {
                Color = "Green";
                Filled = true;
            }

        }

        public class Circle : Shape, IComparable<Circle>
        {
            public double Radius { get; set; }

            public Circle(double radius, string color, bool filled)
            {
                Radius = radius;
                Color = color;
                Filled = filled;
            }

            public double Getarea()
            {
                return Math.PI * Radius * Radius;
            }

            public int CompareTo(Circle other)
            {
                return this.Radius.CompareTo(other.Radius);
            }
        }

        public class Square : Shape, IComparable<Square>
        {
            public double Side { get; set; }

            public Square(double side, string color, bool filled)
            {
                Side = side;
                Color = color;
                Filled = filled;
            }

            public double Getarea()
            {
                return Side * Side;
            }

            public int CompareTo(Square other)
            {
                return this.Side.CompareTo(other.Side);
            }
        }

        public class Rectangular : Shape, IComparable<Rectangular>
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Rectangular(double length, double width, string color, bool filled)
            {
                Length = length;
                Width = width;
                Color = color;
                Filled = filled;
            }

            public double Getarea()
            {
                return Length * Width;
            }

            public int CompareTo(Rectangular other)
            {
                return this.Getarea().CompareTo(other.Getarea());
            }
        }

        public class CircleComparer : IComparer<Circle>
        {
            public int Compare(Circle x, Circle y)
            {
                if (x.Getarea() > y.Getarea())
                {
                    return 1;
                }
                else if (x.Getarea() < y.Getarea())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class SquareComparer : IComparer<Square>
        {
            public int Compare(Square x, Square y)
            {
                if (x.Getarea() > y.Getarea())
                {
                    return 1;
                }
                else if (x.Getarea() < y.Getarea())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class RectangularComparer : IComparer<Rectangular>
        {
            public int Compare(Rectangular x, Rectangular y)
            {
                if (x.Getarea() > y.Getarea())
                {
                    return 1;
                }
                else if (x.Getarea() < y.Getarea())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }


        public class Program
        {

            static void Main(string[] args)
            {
                var circles = new List<Circle>
    {
        new Circle(5.0,"red", true),
        new Circle(3.0,"indigo", false),
        new Circle(7.0,"yellow",true),
        new Circle(1.0,"red",true),
        new Circle(4.0,"orange",true),
    };

                var squares = new List<Square>
    {
        new Square(5.0,"red", true),
        new Square(3.0,"indigo", false),
        new Square(7.0,"yellow",true),
        new Square(1.0,"red",true),
        new Square(4.0,"orange",true),
    };

                var rectangulars = new List<Rectangular>
    {
        new Rectangular(5.0, 2.0,"red", true),
        new Rectangular(3.0, 1.5,"indigo", false),
        new Rectangular(7.0, 3.0,"yellow",true),
        new Rectangular(1.0, 1.0,"red",true),
        new Rectangular(4.0, 2.0,"orange",true),
    };

                // In ra danh sách trước khi sắp xếp
                Console.WriteLine("Danh sách trước khi sắp xếp:");

                Console.WriteLine("\nDanh sách Circle:");
                foreach (var circle in circles)
                {
                    Console.WriteLine($"Bán kính: {circle.Radius}");
                }

                Console.WriteLine("\nDanh sách Square:");
                foreach (var square in squares)
                {
                    Console.WriteLine($"Cạnh: {square.Side}");
                }

                Console.WriteLine("\nDanh sách Rectangular:");
                foreach (var rectangular in rectangulars)
                {
                    Console.WriteLine($"Chiều dài: {rectangular.Length}, Chiều rộng: {rectangular.Width}");
                }

                // Sắp xếp các hình theo diện tích sử dụng IComparer
                circles.Sort(new CircleComparer());
                squares.Sort(new SquareComparer());
                rectangulars.Sort(new RectangularComparer());

                // In ra danh sách sau khi sắp xếp bằng IComparer
                Console.WriteLine("\nDanh sách sau khi sắp xếp bằng IComparer:");

                Console.WriteLine("\nDanh sách Circle:");
                foreach (var circle in circles)
                {
                    Console.WriteLine($"Bán kính: {circle.Radius}, Diện tích: {circle.Getarea()}");
                }

                Console.WriteLine("\nDanh sách Square:");
                foreach (var square in squares)
                {
                    Console.WriteLine($"Cạnh: {square.Side}, Diện tích: {square.Getarea()}");
                }

                Console.WriteLine("\nDanh sách Rectangular:");
                foreach (var rectangular in rectangulars)
                {
                    Console.WriteLine($"Chiều dài: {rectangular.Length}, Chiều rộng: {rectangular.Width}, Diện tích: {rectangular.Getarea()}");
                }
            }
        }
    }
}