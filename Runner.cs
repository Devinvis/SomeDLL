using System;
using System.Collections.Generic;
using System.Text;

namespace CalcGeometricFigure
{
    public class Calc
    {
        void CalcMethod()
        {
            Runner run = new Runner(new Circle(90));
            Runner run2 = new Runner(new Triangle(90, 65, 23.77));

            double chislo = run.GetFigureArea();
            double chislo2 = run2.GetFigureArea();
        }
    }
    public class Runner
    {
        IFigure _figure;
        public Runner(IFigure figure)
        {
            _figure = figure;
        }

        /// <summary>
        /// Вычисление
        /// </summary>
        /// <returns></returns>
        public double GetFigureArea()
        {
            return _figure.CalculateArea();
        }
    }
}
