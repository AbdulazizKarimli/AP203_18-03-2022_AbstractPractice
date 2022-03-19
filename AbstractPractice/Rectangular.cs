using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _lenght;

        public int Width
        {
            get => _width;
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        public int Length
        {
            get => _lenght;
            set
            {
                if(value > 0)
                    _lenght = value;
            }
        }

        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int CalcArea()
        {
            return Width * Length;
        }
    }
}
