using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;
            double val1;
            double val2;
            string op;
            string op2;
            Console.WriteLine("CALCULADORA MAMADISIMA");

            Console.WriteLine("Vas a realizar otra operacion (s/n)?");
            op2 = Console.ReadLine();

            while (op2 == "s")
            {
                Console.Clear();
                Console.WriteLine("Ingresa numero 1");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa numero 2");
                val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Que operacion vas a realizar?");
                op = Console.ReadLine();


                switch (op)
                {
                    case "+":
                        res = val1 + val2;
                        Console.WriteLine("Tu resultado es " + res);

                        break;
                    case "-":
                        res = val1 - val2;
                        Console.WriteLine("Tu resultado es " + res);

                        break;
                    case "/":
                        res = val1 / val2;
                        Console.WriteLine("Tu resultado es " + res);

                        break;
                    case "*":
                        res = val1 * val2;
                        Console.WriteLine("Tu resultado es " + res);

                        break;
                    default:
                        Console.WriteLine("OPERADOR NO VALIDO");

                        break;

                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Vas a realizar otra operacion (s/n)?");
                op2 = Console.ReadLine();

            }


        }
    }
}
