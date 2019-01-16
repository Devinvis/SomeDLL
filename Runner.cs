using System;
using System.Collections.Generic;
using System.Text;

namespace CalcGeometricFigure
{
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
        double GetFigureArea()
        {
            return _figure.CalculateArea();
        }
    }
}
