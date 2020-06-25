using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Rhombus : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Rhombus(double side, double angle)
        {
            if (side <= 0|| angle <= 0)
                throw new Exception("The argument must be greater than zero.");
            if (angle >= 180)
                throw new Exception("Impossible value for rhombus angle");
            Sides = 4;

            _arr = new double[4];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = side;
                //Console.Write($"{side} ");
            }
            //Console.WriteLine();
            SideBase = side;
            AngleSideBase = angle;
            Height = side * Math.Sin(AngleSideBase / 180 * Math.PI);
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
            return SideBase * Sides;
        }
    }
}
