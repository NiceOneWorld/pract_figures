using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    public class CompoundFigure
    {
        private ISimple[] _simples;
        public CompoundFigure(int count) => _simples = new ISimple[count];
        public void AddFigure(ISimple figure)
        {
            for (int i = 0; i < _simples.Length; i++)
            {
                if (_simples[i] == null)
                {
                    _simples[i] = figure;
                    break;
                }
            }
        }

        public double FindArea()
        {
            double sum = 0;
            for (int i = 0; i < _simples.Length; i++)
            {
                if(_simples[i] is Square)
                    sum += ((Square)_simples[i]).Area();
                else if (_simples[i] is Rectangle)
                    sum += ((Rectangle)_simples[i]).Area();
                else if (_simples[i] is Rhombus)
                    sum += ((Rhombus)_simples[i]).Area();
                else if (_simples[i] is Parallelogram)
                    sum += ((Parallelogram)_simples[i]).Area();
                else if (_simples[i] is Triangle)
                    sum += ((Triangle)_simples[i]).Area();
            }
            return sum;
        }
    }
}