using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    public class Square : GeometricFigure, ISimple
    {
        private readonly double[] _arr;

        public Square(double side)
        {
            if (side <= 0)
                throw new Exception("The argument must be greater than zero.");
            Sides = 4;
                _arr = new double[4];
                for (int i = 0; i < _arr.Length; i++)
                {
                     _arr[i] = side;
                  //Console.Write($"{side} ");
                }
                //Console.WriteLine();
                Height = side;
                SideBase = side;
                AngleSideBase = 90;   
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

        public double SideBase  { get; set; }

        public double AngleSideBase { get; set; }

        public int Sides { get; set; }
        
        public override double Area()
        { 
            return Math.Pow(SideBase, 2);
        }

        public override double Perimeter()
        {
            return SideBase * Sides;
        }
    }
}
