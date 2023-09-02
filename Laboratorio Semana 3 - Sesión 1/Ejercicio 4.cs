using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1;
            int RESUL; // Declarar la variable RESUL
            string linea;

            Console.Write("DIGITE UN NÚMERO :");
            linea = Console.ReadLine();

            while (!int.TryParse(linea, out NUM1)) // Verificar si la entrada es un número
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número:");
                linea = Console.ReadLine();
            }

            RESUL = Math.Abs(NUM1); // Calcular el valor absoluto de NUM1 y almacenarlo en RESUL
            Console.WriteLine("VALOR ABSOLUTO : " + RESUL);
            Console.WriteLine("POTENCIA : " + Math.Pow(NUM1, 3));
            Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("COSENO : " + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("NÚMERO MÁXIMO : " + Math.Max(NUM1, 50));
            Console.WriteLine("NÚMERO MÍNIMO : " + Math.Min(NUM1, 50));
            Console.WriteLine("PARTE ENTERA : " + Math.Truncate((double)NUM1)); // Convertir NUM1 a double antes de Truncate
            Console.WriteLine("REDONDEO : " + Math.Round((double)NUM1)); // Convertir NUM1 a double antes de redondear
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}