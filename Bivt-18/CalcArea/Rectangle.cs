using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea
{
    public class Rectangle : IFigure
    {
        public float A { get; set; }
        public float B { get; set; }

        public string EnterParamsTitle => "Введите стороны А и B через запятую";
        public string OutputTitle =>"Площадь прямоугольника: ";

        public void Init(float[] args)
        {
            A = args[0];
            B = args[1];
        }

        public double CalcArea()
        {
            return A * B;
        }
    }
}
