using System;

namespace ClassLibraryShapes
{
    public class Triangle : IFigure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть положительными");
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }
        public double FindSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)),2);
        }

        public bool IsRight()
        {
            return (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2) ||
                    Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2) ||
                    Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2));
        }
    }
}
