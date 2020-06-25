using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    public interface ISimple
    {
        double Height { get; set; }
        double SideBase { get; set; }
        double AngleSideBase { get; set; }
        int Sides { get; set; }
        double this[int pos] { get; set; } // Sides lengths


    }


}
