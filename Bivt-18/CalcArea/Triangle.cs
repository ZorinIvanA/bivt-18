using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea
{
    public class Triangle : IFigure
    {
        public float A { get; private set; }
        public float B { get; private set; }
        public float C { get; private set; }

        public string EnterParamsTitle => "Введите стороны А, B, C через запятую";
        public string OutputTitle => "Площадь треугольника: ";
        public void Init(float[] args)
        {
            A = args[0];
            B = args[1];
            C = args[2];
        }

        public double CalcArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
