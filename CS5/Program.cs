using System;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30092026
            // Sintaxis: while
            // inicialización;
            // while(expresión)
            // {
            //     bloque de instrucciones
            //     iterador;
            // }
            // Iterar: repetir

            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicialización
            while (m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1;
            }

            // Ascendente
            int it1 = 1;
            while (it1 > 0)
            {
                Console.WriteLine($"it1: {it1}");
                it1++;
            }

            // Descendente
            int it2 = 99;
            while (it2 > 0)
            {
                Console.WriteLine($"it2: {it2}");
                it2--;
            }
        }
    }
}
