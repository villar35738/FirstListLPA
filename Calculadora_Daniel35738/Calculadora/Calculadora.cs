using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {

        public static double Somar(double a, double b)
        {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        public static double Dividir(double a, double b)
        {
            return a / b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Potencia(int a, int b)
        {

            int resultado = 1;

            for (int i = 0; i < b; i++)
            {

                resultado *= a;
            }

            return resultado;
        }

        public static double[] Baskara(double a, double b, double c)
        {

            double[] x = new double[2];
            double delta = b*b - 4 * a * c;

            if (delta < 0)
            {
                return null;
            }

            x[0] = (-b + Math.Sqrt(delta)) / (2 * a);
            x[1] = (-b - Math.Sqrt(delta)) / (2 * a);

            return x;
        }

    }
}
