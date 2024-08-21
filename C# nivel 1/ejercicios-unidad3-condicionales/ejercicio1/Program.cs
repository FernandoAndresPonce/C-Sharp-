using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si 
             “Es mayor a 10” o “No es mayor a 10”.
            */

            int numeroIngresado;

            Console.WriteLine("\nIngrese un numero y le dire si es MAYOR, MENOR o IGUAL a 10.");
            numeroIngresado = int.Parse(Console.ReadLine());

            if (numeroIngresado > 10)
                Console.WriteLine("Es MAYOR a 10.\n");

            else if (numeroIngresado == 10)
                Console.WriteLine("Es IGUAL a 10.\n");

            else
                Console.WriteLine("Es MENOR a 10.\n");
        }

    }
}
