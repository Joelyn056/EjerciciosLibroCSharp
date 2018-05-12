using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosAsignados.Capitulo_2
{
    class Ejercicio5
    {
        public static void ConvertirMonedas()
        {
            string entrada = "";


            int i = 0;
            float conversion = 0f;
            float cantidad = 0f;
            float resultado = 0f;

            Console.WriteLine("\t \t Conversor de Monedas \n \n --Ingrese Opcion deseada-- \n 1-Conversion de dolar \n 2-Conversion de Euros  "); // Escribe por pantalla un string

            entrada = Console.ReadLine();
            i = System.Int32.Parse(entrada);
            switch (i)
            {
                case 1:
                    Console.WriteLine("\n ---Usted seleciono Convercion de dolar--- ");
                    Console.Write("Ingrese taza de cambio del dia: ");
                    entrada = Console.ReadLine();

                    conversion = Convert.ToSingle(entrada);
                    Console.Write("\n Ingrese cantidad de dolares a convertir ");
                    entrada = Console.ReadLine();

                    cantidad = Convert.ToSingle(entrada);
                    resultado = cantidad * conversion;
                    Console.Write("\n Resultado de conversion es  {0 }", resultado);


                    break;
                case 2:
                    Console.WriteLine("---Usted seleciono Convercion de Euros--- ");
                    Console.Write("Ingrese taza de camnbio del dia: ");
                    entrada = Console.ReadLine();

                    conversion = Convert.ToSingle(entrada);
                    Console.Write("\n Ingrese cantidad de dolares a convertir ");
                    entrada = Console.ReadLine();

                    cantidad = Convert.ToSingle(entrada);
                    resultado = cantidad * conversion;
                    Console.Write("\n Resultado de conversion es  {0 }", resultado);

                    break;
                default:

                    break;
            }

            Console.ReadKey();
        }
    }
}
