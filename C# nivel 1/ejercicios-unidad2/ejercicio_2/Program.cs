using System;
using System.Linq.Expressions;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para solicitar por teclado un número y 
            luego devolver su valor elevado al cubo.
            */
            
            int n1, resultado;

            Console.WriteLine("Ingrese el numero que desea elevarlo al cubo: ");
            n1 = int.Parse(Console.ReadLine());

            resultado = n1*n1*n1;

            Console.WriteLine("El resultado del numero " + n1 + " al cubo es " + resultado + ".");
        }
    }
}
