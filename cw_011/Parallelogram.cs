using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Parallelogram : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Parallelogram(double sideBase, double side2, double angle)
        {
            if (sideBase <= 0 || side2 <= 0 || angle <= 0)
                throw new Exception("The argument must be greater than zero.");
            if (angle >= 180)
                throw new Exception("Impossible value for Parallelogram angle");
            Sides = 4;
            _arr = new double[4];
            SideBase = sideBase;
            AngleSideBase = angle;
            Height = side2 * Math.Sin(AngleSideBase / 180 * Math.PI);
            for (int i = 0; i < _arr.Length; i++)
            {
                if (i == (i % 2))
                {
                    _arr[i] = side2;
                    //Console.Write($"{side2} ");
                }
                else
                {
                    _arr[i] = sideBase;
                    //Console.Write($"{sideBase} ");
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
            return (SideBase + _arr[0]) * 2;
        }
    }
}
