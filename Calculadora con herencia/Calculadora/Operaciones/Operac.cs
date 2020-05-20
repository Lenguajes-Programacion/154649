using System;
using System.Collections.Generic;
using System.Text;


namespace Calculadora.Operaciones
{
    class Operac
    {
        public double a;
        public double b;

        public static double Suma(double a, double b)
        {
            double Res = 0;
            Res = a + b;
            return Res;
        }
        public static double Resta(double a, double b)
        {
            double Res = 0;
            Res = a - b;
            return Res;
        }
        public static double Divicion(double a, double b)
        {
            double Res = 0;
            Res = a / b;
            return Res;
        }
        public static double Multiplicacion(double a, double b)
        {
            double Res = 0;
            Res = a * b;
            return Res;
        }
        public void Potencia(double a, double b)
        {
            double Pot = Math.Pow(a, b);
            Console.WriteLine(" {0} elevado a {1} es {2}", a, b, Pot);
        }

    }
}
