using System;

namespace acuCon
{
    class Program
    {
        static void Main(string[] args)
        {   
            int promedio, edad = 40, edad1 = 20, edad2 = 30;

            // Podemos plantarlo de dos maneras , declarando a las variables la de arriba o la de abajo.

            int contador = 0;
            int acumulador = 0;

            if (edad > 19){
                contador++;
                acumulador += edad;
            }

            if (edad1 > 18){
                contador++;
                acumulador += edad1;
            }

            if (edad2 > 20){
                contador++;
                acumulador += edad2;
            } 

            promedio = acumulador / contador;

            Console.WriteLine("\nCantidad: " + contador + 
            "\nAcumulador: " + acumulador + 
            "\nPromedio: " + promedio+"\n");




            
            
        }
    }
}
