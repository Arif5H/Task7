using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cilinder : Figures
    {
       

        public double Area()
        {   

            return 2*CircleArea()+2*Math.PI*Radius*Height;
        }
        public double Volume()
        {
            return CircleArea()*Height;
        }

    }
}
