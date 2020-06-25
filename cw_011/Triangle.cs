using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Triangle : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Triangle(double sideBase, double side2, double angle)
        {
            if (sideBase <= 0 || side2 <= 0|| angle <=0)
                throw new Exception("The argument must be greater than zero.");
            double thirdSide = Math.Sqrt((Math.Pow(side2, 2) + Math.Pow(sideBase, 2) - Math.Cos(angle / 180 * Math.PI) * ((side2 * sideBase) * 2)));
            //if (sideBase + side2 < thirdSide && sideBase + thirdSide < side2 && side2 + thirdSide < sideBase)
            //    throw new Exception("The sum of the lengths of two sides, less than the length of the third.");
            if (angle >= 180)
                throw new Exception("Impossible value for triangle angle");
            Sides = 3;
            SideBase = sideBase;
            AngleSideBase = angle;
            Height = side2 * Math.Sin(AngleSideBase / 180 * Math.PI);
            _arr = new double[3];
            _arr[0] = side2;
            _arr[1] = sideBase;
            _arr[2] = thirdSide;
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

        public double ThirdSide()
        {
            return Math.Sqrt((Math.Pow(_arr[0], 2) + Math.Pow(SideBase, 2) - Math.Cos(AngleSideBase / 180 * Math.PI) * ((_arr[0] * SideBase) * 2)));
        }

        public override double Area()
        {
            return 0.5 * SideBase * Height;
        }

        public override double Perimeter()
        {
            return SideBase + _arr[0] + ThirdSide();
        }
    }
}
