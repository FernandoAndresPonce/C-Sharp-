using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para ingresar un número y luego se emita un cartel por pantalla 
            “Positivo” si el número es mayor a cero, 
            “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            */
        
            int numeroIngresado;

            Console.WriteLine("\nIngrese un Numero, y le dire si es POSITIVO, NEGATIVO o CERO\n");
            numeroIngresado = int.Parse(Console.ReadLine());

            if (numeroIngresado > 0)
                Console.WriteLine("\nPOSITIVO\n");
            
            else if (numeroIngresado == 0)
                Console.WriteLine("\nCERO\n");
            
            else
                Console.WriteLine("\nNEGATIVO\n");


        }

    }
}
