using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Figures: Circle
    {
        
        protected double height;
        protected double side;

        

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                if (height<0)
                {
                    throw new Exception("Height of a figure can't be a negative value");
                }
            }
        }
        public double Side
        {
            get { return side; }
            set
            {
                side = value;
                if(side<0)
                    throw new Exception("Side of a figure can't be a negative value");
            }
        }
        public static double CheckForDigits(string caption)
        {
            double anynumber;
        TryAgain:
            Console.Write(caption);
            try
            {
                anynumber = Convert.ToInt32(Console.ReadLine());
                return anynumber;
            }
            catch
            {
                Console.WriteLine("Please enter only digits. Try Again!!");
                goto TryAgain;
            }
        }

        



    }
}
