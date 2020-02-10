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
            bool cerrar = true;

           
          

            while (cerrar)
            {
             
                Console.Clear();
                Console.WriteLine("CALCULADORA MAMADISIMA");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Ingresa numero 1");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa numero 2");
                val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" + para suma");
                Console.WriteLine(" - para resta");
                Console.WriteLine(" * para multiplicacion");
                Console.WriteLine(" / para divicion");
                Console.WriteLine(" s para salir");
                Console.WriteLine("----------------------------------------------");
                op = Console.ReadLine();
                
                switch (op)
                {
                    case "+":
                        res = val1 + val2;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Tu resultado es " + res);
                    

                        break;
                    case "-":
                        res = val1 - val2;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Tu resultado es " + res);
                       

                        break;
                    case "/":
                        res = val1 / val2;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Tu resultado es " + res);
                     

                        break;
                    case "*":
                        res = val1 * val2;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Tu resultado es " + res);
                       
                        break;
                    case "s":

                        cerrar = false;

                        break;
                    
                    default:
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("OPERADOR NO VALIDO");

                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Deseas realizar otra operacion (s/n)");
                op2 = Console.ReadLine();

                if (op2 == "s")
                {
                    cerrar = true;
                }
                else
                {
                    cerrar = false;
                }



            }


        }
    }
}
