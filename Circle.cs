using System;
using System.Collections.Generic;
using System.Text;

namespace CalcGeometricFigure
{
    class Circle : IFigure
    {
        /// <summary>
        /// Radius
        /// </summary>
        readonly double r;
        public Circle(double Radius)
        {
            r = Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
