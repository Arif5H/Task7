using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle
    {
        protected double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                if(radius<0)
                {
                    throw new Exception("Radius of Figure can't be a negative value");
                }
            }
        }
        protected double CircleArea ()
        {

            return Math.Round(Math.PI, 2)*Math.Pow(Radius,2);
        }
    }
}
