using System;

namespace ClassLibraryShapes
{
    public class Circle : IFigure
    {
        private double R { get; set; }
        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("Радиус должен быть положительным");
            else 
                R = r;
        }

        public double FindSquare()
        {
            return Math.Round(Math.PI * Math.Pow(R, 2),2);
        }
    }
}
