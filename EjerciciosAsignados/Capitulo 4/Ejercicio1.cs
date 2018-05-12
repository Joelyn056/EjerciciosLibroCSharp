using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosAsignados.Capitulo_4
{
    class Ejercicio1
    {
        public static void TablaMulti()
        {

            int n = 0;
            int resultado = 0;

            Console.WriteLine("Ingrese Numero a multiplicar");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                resultado = n * i;
                Console.WriteLine(n + "x" + i + "=" + resultado);

            }
            Console.ReadKey();

        }
    }
}
