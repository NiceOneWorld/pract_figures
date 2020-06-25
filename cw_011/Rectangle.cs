using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Rectangle : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Rectangle(double height, double side)
        {
            if (side <= 0 || height <= 0)
            {
                throw new Exception("The argument must be greater than zero.");
            }
            Sides = 4;
            Height = height;
            SideBase = side;
            AngleSideBase = 90;
            _arr = new double[4];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (i != (i%2))
                {
                    _arr[i] = height;
                    //Console.Write($"{height} ");
                }
                else
                {
                    _arr[i] = side;
                   // Console.Write($"{side} ");
                }
            }
            //Console.WriteLine();
        }
        public double this[int pos]
        {
            get
            {
                return _arr[pos];
            }
            set
            {
                _arr[pos] = value;
            }
        }
        public double Height { get; set; }

        public double SideBase { get; set; }

        public double AngleSideBase { get; set; }

        public int Sides { get; set; }
        public override double Area()
        {
            return SideBase * Height;
        }
        public override double Perimeter()
        {
            return (SideBase + Height) * 2;
        }
    }
}
