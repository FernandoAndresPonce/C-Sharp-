using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            */
            int con = 0;
            int acu = 0;
            int promedio;
            int[] numeros = new int[10];
            
            Console.WriteLine("\nIngrese 10 numeros, y le mostrare el PROMEDIO, y que valores son MAYORES.\n");
            Console.WriteLine("INGRESOS DE NUMEROS:");

            for (int x = 0; x < 10; x++){
                
                numeros[x] = int.Parse(Console.ReadLine());

            }

            for (int x = 0; x < 10; x++){
                con++;
                acu+=numeros[x];
            }

            promedio = acu / con;

            Console.WriteLine("\nPROMEDIO: " + promedio + "\n");
            Console.Write("MAYORES AL PROMEDIO: ");

            for (int x = 0; x < 10; x++){
                if (numeros[x] > promedio)
                    Console.Write(numeros[x] +", ");
            }        


        
        
        
        }
    }
}
