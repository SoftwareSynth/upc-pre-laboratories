using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, CEN, DEC, UNI;

            string linea;
            Console.WriteLine("INGRESE NÚMERO DE TRES CIFRAS :");
            linea = Console.ReadLine();

            if (int.TryParse(linea, out NUM) && linea.Length == 3)
            {
                CEN = NUM / 100;
                NUM = NUM % 100;
                DEC = NUM / 10;
                UNI = NUM % 10;
                AUX = (UNI * 100) + (DEC * 10) + CEN;
                Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número de tres cifras válidas.");
            }

            Console.WriteLine("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}