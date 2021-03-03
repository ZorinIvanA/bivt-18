using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea
{
    public interface IFigure
    {
        public string EnterParamsTitle { get; }
        public string OutputTitle { get; }

        public void Init(float[] args);
        public double CalcArea();
    }
}
