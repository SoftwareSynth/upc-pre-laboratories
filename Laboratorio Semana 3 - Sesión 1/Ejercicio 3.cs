C#
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, RESUL;
            string linea;

            Console.Write("PRIMER NÚMERO :");
            linea = Console.ReadLine();

            if (int.TryParse(linea, out NUM1))
            {
                Console.Write("SEGUNDO NÚMERO :");
                linea = Console.ReadLine();

                if (int.TryParse(linea, out NUM2))
                {
                    Console.WriteLine();
                    RESUL = NUM1 + NUM2;
                    Console.WriteLine("LA SUMA ES: {0}", RESUL);
                    RESUL = NUM1 - NUM2;
                    Console.WriteLine("LA RESTA ES: {0} - {1} = {2}", NUM1, NUM2, RESUL);
                    RESUL = NUM1 * NUM2;
                    Console.WriteLine("LA MULTIPLICACIÓN ES: {0}", RESUL);

                    if (NUM2 != 0)
                    {
                        RESUL = NUM1 / NUM2;
                        Console.WriteLine("LA DIVISIÓN ES: {0}", RESUL);
                        RESUL = NUM1 % NUM2;
                        Console.WriteLine("EL RESIDUO ES: {0}", RESUL);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }

                    Console.Write("Pulse una Tecla:");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Segundo número no válido.");
                }
            }
            else
            {
                Console.WriteLine("Primer número no válido.");
            }
        }
    }
}