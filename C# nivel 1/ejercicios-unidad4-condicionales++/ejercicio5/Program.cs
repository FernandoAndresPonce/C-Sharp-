using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
             si los mismos se encuentran ordenados de forma decreciente .
            */

            int num1, num2, num3, num4;

            Console.Write("\nIngrese el PRIMER numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el SEGUNDO numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el TERCERO numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el CUARTO numero: ");
            num4 = int.Parse(Console.ReadLine());
        
            if (num1 > num2 && num2 > num3 && num3 > num4)
                Console.WriteLine("\nEsta ordenado de forma DECRECIENTE\n");
            else if  (num1 < num2 && num2 < num3 && num3 < num4)
                Console.WriteLine("\nEsta ordenado de forma CRECIENTE\n");
            else
                Console.WriteLine("\nEsta DESORDENADO\n");









        }
    }
}