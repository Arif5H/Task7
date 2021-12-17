using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        step1:
            try
            {
                Right_Angled_Paralillepiped paralillepiped = new Right_Angled_Paralillepiped();
                paralillepiped.Height = Figures.CheckForDigits("What is the height of paralillepiped? ");
                paralillepiped.Side = Figures.CheckForDigits("What is the Side of paralillepiped? ");
                paralillepiped.Width = Figures.CheckForDigits("What is the Width of paralillepiped? ");
                Console.WriteLine($"Total Area of Cylinder {paralillepiped.Area()} " + $" Volume of Cylinder {paralillepiped.Volume()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Try Again");
                goto step1;
            }

            Cilinder cilinder = new Cilinder();
        step2:
            try
            {
                cilinder.Radius = Figures.CheckForDigits("What is the radius of the Cylinder? ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto step2;
            }
             step5:
                try
                {
                cilinder.Height = Figures.CheckForDigits("What is the height of Cylinder? ");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto step5;
                }
                Console.WriteLine($"Total Area of Cylinder {cilinder.Area()} " + $" Volume of Cylinder {cilinder.Volume()}");



        step3:
            Konus konus = new Konus();
            try
            {
                konus.Radius = Figures.CheckForDigits("What is the radius of the Konus? ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto step3;
            }
        step4:
            try
            {
                konus.Height = Figures.CheckForDigits("What is the Height of konus?  ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto step4;
            }
            Console.WriteLine($"Total Area of Cone {konus.Area()} " + $" Volume of Cone {konus.Volume()}");

        }
    }
}
