using System;
using Calculadora.Operaciones;
namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {            
            double a = 0;
            double b = 0;
            double Res = 0;
            Operac Potencia = new Operac();
            int Eleccion;
            do
            {
                Console.WriteLine("Calculadora con Herencia");
                Console.WriteLine("---------------");



                Console.WriteLine("1. Suma\n");
                Console.WriteLine("2. Resta\n");
                Console.WriteLine("3. Multiplicacion\n");
                Console.WriteLine("4. Divicion\n");
                Console.WriteLine("5. Potencia\n");
                Console.WriteLine("-------------------");
                Console.WriteLine("6. Salir\n");
                

                Eleccion = Int32.Parse(Console.ReadLine());
                switch (Eleccion)
                {
                    //--------------------------------------------------------------------------------
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-SUMA-");

                        Console.WriteLine("Primer Valor ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo Valor: ");
                        b = double.Parse(Console.ReadLine());

                        Res = Operac.Suma(a, b);

                        Console.WriteLine("Su resultado es " + Res);
                        Console.WriteLine("");
                        Console.Write("Presione enter para continuar... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    //--------------------------------------------------------------------------------
                    case 2:
                        Console.Clear();
                        Console.WriteLine("-RESTA-");

                        Console.WriteLine("Primer Valor ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo Valor: ");
                        b = double.Parse(Console.ReadLine());

                        Res = Operac.Resta(a, b);

                        Console.WriteLine("Su resultado es " + Res);
                        Console.WriteLine("");
                        Console.Write("Presione enter para continuar... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    //--------------------------------------------------------------------------------
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-MULTIPLICACION-");

                        Console.WriteLine("Primer Valor ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo Valor: ");
                        b = double.Parse(Console.ReadLine());

                        Res = Operac.Multiplicacion(a, b);

                        Console.WriteLine("Su resultado es " + Res);
                        Console.WriteLine("");
                        Console.Write("Presione enter para continuar... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    //--------------------------------------------------------------------------------
                    case 4:
                        Console.Clear();
                        Console.WriteLine("-DIVISION-");

                        Console.WriteLine("Primer Valor ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo Valor: ");
                        b = double.Parse(Console.ReadLine());

                        Res = Operac.Divicion(a, b);

                        Console.WriteLine("Su resultado es " + Res);
                        Console.WriteLine("");
                        Console.Write("Presione enter para continuar... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    //--------------------------------------------------------------------------------
                    case 5:
                        Console.Clear();
                        Console.WriteLine("-POTENCIA-");
                        Console.WriteLine("Valor base: ");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo Valor: ");
                        b = Int32.Parse(Console.ReadLine());

                        Potencia.Potencia(a, b);
                        Console.WriteLine("");
                        Console.Write("Presione enter para continuar... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                       
                    //--------------------------------------------------------------------------------
                    case 6:
                        Console.Clear();
                        Console.WriteLine("SALIENDO");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(1000);

                        break;
                    //--------------------------------------------------------------------------------
                    default:
                        Console.Clear();
                        Console.WriteLine("Operacion no valida");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        break;
                   //--------------------------------------------------------------------------------
                }
            } while (Eleccion != 6);
        }
    }

      
}


