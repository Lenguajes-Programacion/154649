using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA MAMADISIMA");
            int res;
            int val1;
            int val2;
            string op;

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
                    Console.WriteLine("Tu resultado es "+res);

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
        }
    }
}
