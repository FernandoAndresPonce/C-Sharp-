using System;
using System.Reflection;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
             luego calcule y emita por pantalla el promedio final.
            */

            float nota1, nota2, nota3, promedioFinal;
            const int cantidadNotas = 3;

        
            Console.WriteLine("Ingrese Nota Numero 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota Numero 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota Numero 3: ");
            nota3 = float.Parse(Console.ReadLine());

            promedioFinal = (nota1 + nota2 + nota3) / cantidadNotas;

            Console.WriteLine("\nEl promedio de:\n\nNota 1: " + nota1 + "\nNota 2: " +  nota2 + "\nNota 3: " 
            + nota3 + "\nPromedio Final: " + promedioFinal.ToString("0.00") + "\n");


        }
    }
}
