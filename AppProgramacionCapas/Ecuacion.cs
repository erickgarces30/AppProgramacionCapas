using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramacionCapas
{
    public static class Ecuacion
    {
        public static double x1(double a, double b, double c, out string msg)
        {

            double x1 = 0;
            msg = "";

            if (a == 0)
            {
                msg = "Error, división por cero...";
                return 0;//abandonar
            }



            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                msg = "Raíce negativas. La ecuación tiene solución imaginaria...";
                return 0;
            }
            x1 = (-b + Math.Sqrt(d)) / (2 * a);

            return x1;

        }
        public static double x2(double a, double b, double c, out string msg)
        {

            double x2 = 0;
            msg = "";

            if (a == 0)
            {
                msg = "Error, división por cero...";
                return 0;//abandonar
            }



            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                msg = "Raíce negativas. La ecuación tiene solución imaginaria...";
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            return x2;

        }

        public static double getx1(double a, double b, double c)
        {

            double x1 = 0;

            if (a == 0)
            
                throw new Exception("Error, división por cero...");
                
                double d = (b * b) - (4 * a * c);

                if (d < 0)

                    throw new Exception("Raíce negativas. La ecuación tiene solución imaginaria...");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);

                return x1;
            }
        }
}
