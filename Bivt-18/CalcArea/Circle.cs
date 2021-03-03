using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea
{
    public class Circle : IFigure
    {
        public float R { get; set; }
        public string EnterParamsTitle => "Введите радиус";
        public string OutputTitle => "Площадь круга: ";

        public void Init(float[] args)
        {
            R = args[0];
        }

        public double CalcArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
