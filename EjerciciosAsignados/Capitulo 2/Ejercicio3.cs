using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosAsignados.Capitulo_2
{
    class Ejercicio3
    {
        public static void NumRadia()
        {

            string entrada = "";

            float radianas = 0;

            float resultado = 0;

            Console.WriteLine("Ingrese Numero Radianaes a convertir  ");
            entrada = Console.ReadLine();
            radianas = Convert.ToSingle(entrada);
            resultado = (3.14f * radianas) / 180;

            Console.Write("Resultado es " + resultado);
            Console.ReadKey();
        }
    }
}
