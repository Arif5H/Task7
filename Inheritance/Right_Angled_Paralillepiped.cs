using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Right_Angled_Paralillepiped : Figures
    {
        protected double width;
        public double Width
        {   
            get { return width; }
            set
            {
                width = value;
                if (width < 0)
                {
                    throw new Exception("Width of Figure can't be a negative value");
                }
            }
        }
       

       public double Area()
        {


            return 2 *(Side*Height+Height*Width+Side*Width);
        }

        public double Volume()
        {

            return Side * Height * Width;
        }
    }
}
