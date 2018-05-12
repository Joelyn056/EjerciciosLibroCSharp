using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosAsignados.Capitulo_2
{
    class Ejercicio1
    {
        public static void CalcularPerimetro()
        {

            double perimetro = 0, lado = 0, cantidad = 0;


            Console.WriteLine("######Encontrar el Perimetro  de un Poligono#####\n");


            Console.Write("Ingrese cantidad de lados del Poligono: ");
            cantidad = Int32.Parse(Console.ReadLine());


            Console.Write("Ingrese el lados del Poligono:");
            lado = Int32.Parse(Console.ReadLine());

            perimetro = cantidad * lado;

            Console.WriteLine("\n El Area del Poligono: " + perimetro);

            Console.ReadKey();

        }
    }
}
