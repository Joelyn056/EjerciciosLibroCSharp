using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosAsignados.Capitulo_3
{
    class Ejercicio1
    {
        public static void Par()
        {
            
            string entrada = "";


            int i = 0;
            int par = 0;

            Console.WriteLine("\t \t Par o impar \n ");


            Console.WriteLine("Ingrese un numero ");

            entrada = Console.ReadLine();
            par = System.Int32.Parse(entrada);

            if (par % 2 == 0)
            {
                Console.WriteLine("Numero es par");

            }
            else
            {
                Console.WriteLine("Numero es Impar");
            }

            Console.ReadKey();

        }
    }
}
