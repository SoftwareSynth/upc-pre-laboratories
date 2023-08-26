using System;
using System.Collections.Generic;

namespace EjemploList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> miLista = new List<string>();
            miLista.Add("Primero");
            miLista.Add("Segundo");
            miLista.Add("Tercero");
            miLista.Add("Cuarto");
            miLista.Add("Quinto");

            foreach (string cadena in miLista)
                Console.Write(cadena + " ");

            Console.WriteLine();

            // Accedemos a una posición
            Console.WriteLine("La segunda cadena es: {0}", miLista[1]);

            // Insertamos en la segunda posición
            miLista.Insert(1, "Después de Primero");
            miLista.Insert(0, "Al principio");

            // Mostramos lo que contiene
            Console.WriteLine("Contenido tras inserciones:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Buscamos un elemento
            int indexTercero = miLista.IndexOf("Tercero");
            Console.WriteLine("La palabra \"Tercero\" está en la posición {0}", indexTercero);

            // Ordenamos
            miLista.Sort();

            // Mostramos lo que contiene
            Console.WriteLine("Contenido tras ordenar:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Buscamos con búsqueda binaria
            int indexCuarto = miLista.BinarySearch("Cuarto");
            Console.WriteLine("Ahora \"Cuarto\" está en la posición {0}", indexCuarto);

            // Invertimos la lista
            miLista.Reverse();

            // Borramos el segundo dato y la palabra "Quinto"
            miLista.RemoveAt(1);
            miLista.Remove("Quinto");

            // Mostramos nuevamente lo que contiene
            Console.WriteLine("Contenido tras dar la vuelta y eliminar dos:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Ordenamos y vemos dónde iría un nuevo dato
            miLista.Sort();
            Console.WriteLine("La frase \"Primero\"...");
            int posicionPrimero = miLista.BinarySearch("Primero");
            if (posicionPrimero >= 0)
                Console.WriteLine("Está en la posición {0}", posicionPrimero);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor es el {0}: {1}",
                ~posicionPrimero, miLista[~posicionPrimero]);

            Console.WriteLine("La frase \"Sexto\"...");
            int posicionSexto = miLista.BinarySearch("Sexto");
            if (posicionSexto >= 0)
                Console.WriteLine("Está en la posición {0}", posicionSexto);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor es el {0}: {1}",
                ~posicionSexto, miLista[~posicionSexto]);

            Console.ReadKey();
        }
    }
}
