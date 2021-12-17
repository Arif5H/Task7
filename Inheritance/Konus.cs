using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Konus : Figures
    {
        
        public double Area()
        {
            Side = Math.Sqrt(Math.Pow(Radius,2) + Math.Pow(Height, 2));
            return CircleArea() + Math.Round(Math.PI,2)  * Side*Radius;
        }

        public double Volume ()
        {
            return CircleArea() * Height / 3;
        }



                
    }





}
