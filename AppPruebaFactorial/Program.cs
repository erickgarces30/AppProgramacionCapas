using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebaFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            double res = AppProgramacionCapas.Factorial.fact(num);
            Console.WriteLine("El factorial es: {0} es: {1} ", num, res );

            cambio(27.50);
            Console.ReadKey(); //Pausa

        }

        static void cambio(double dolares)
        {
            int billete10 = (int)dolares / 10;
            Console.WriteLine("{0} billetes de 10 dólares", billete10);

            int billete5 = ((int)dolares % 10) / 5;
            Console.WriteLine("{0} billetes de 5 dólares", billete5);

            int billete1 = (((int)dolares % 10) % 5) / 1;
            Console.WriteLine("{0} billetes de 1 dólar", billete1);

            int moneda50 = (((int)dolares % 10) % 5) % 1)/0.50;
            Console.WriteLine("{0} monedas de 50 centavos", moneda50);
        }

    }
}
