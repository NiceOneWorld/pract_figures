using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Circle : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("The argument must be greater than zero.");
            Sides = 1;
            _arr = new double[1];
            Height = radius*2;
            SideBase = radius;
            AngleSideBase = 0;
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
            return Math.PI * Math.Pow(SideBase,2);
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * SideBase;
        }
    }
}
