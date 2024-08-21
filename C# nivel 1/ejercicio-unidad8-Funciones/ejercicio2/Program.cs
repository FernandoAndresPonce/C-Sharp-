using System;
using System.Dynamic;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            */

            int numeros;
            int con=0;
            


            Console.WriteLine("\nINGRESE 10 NUMEROS, Y LE MOSTRARE CUANTOS SON PARES.\n");

            for (int x = 0; x < 10; x++)
            {
                
                if(par(numeros = int.Parse(Console.ReadLine())))
                {
                    con++;
                }

            }

            Console.WriteLine("\nCANTIDAD PARES: " + con);
             
        }

        static bool par(int a )
        {   
        
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
                
        }
    }
}

        

