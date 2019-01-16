using System;
using System.Collections.Generic;
using System.Text;

namespace CalcGeometricFigure
{
    class Triangle : IFigure
    {
        readonly double a;
        readonly double b;
        readonly double c;

        /// <summary>
        /// Площадь
        /// </summary>
        double S;
        /// <summary>
        /// Полупериметр
        /// </summary>
        double P;

        readonly bool isRightTriangle;

        public Triangle(double Aside, double Bside, double Cside)
        {
            a = Aside;
            b = Bside;
            c = Cside;

            isRightTriangle = GetInfoAboutTriangle();
        }

        bool IsPythagoreanTheoremRight (double hypotenuse, double leg1, double leg2)
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(leg1, 2) + Math.Pow(leg2, 2);
        }
            
        /// <summary>
        /// Получение информации о треугольнике
        /// </summary>
        /// <returns></returns>
        bool GetInfoAboutTriangle()
        {
            double maxLengthOfSide;
            
            if (a > b && a > c)
            {
                maxLengthOfSide = a;
                return IsPythagoreanTheoremRight(maxLengthOfSide, b, c);

            }
            else if (b > c)
            {
                maxLengthOfSide = b;
                return IsPythagoreanTheoremRight(maxLengthOfSide, a, c);
            }
            else
            {
                maxLengthOfSide = c;
                return IsPythagoreanTheoremRight(maxLengthOfSide, a, b);
            }
            
        }
        public double CalculateArea()
        {
            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
    }
}
