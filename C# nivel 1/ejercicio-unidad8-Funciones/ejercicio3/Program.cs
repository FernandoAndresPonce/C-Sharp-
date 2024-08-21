using System;
using System.Diagnostics.CodeAnalysis;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            Informar el promedio teniendo en cuenta sólo los números primos.
            */
        
            int numeros, con = 0, acu = 0;
            float promedio;

            Console.WriteLine("\nINGRESE LA CANTIDAD DE NUMEROS QUE DESEE, Y LE DIRE EL PROMEDIO DE LOS PRIMOS\n");
            numeros = int.Parse(Console.ReadLine());


            while (numeros != 0)
            {
                if(primo(numeros))
                {
                    con++;
                    acu += numeros;
                }
                numeros = int.Parse(Console.ReadLine());
            }

            promedio = acu / con;

            Console.WriteLine("\nCANTIDAD NUMEROS PRIMOS: " + con + "\nSUMA DE NUMEROS PRIMOS: " + acu + "\nPROMEDIO: " + promedio.ToString("0.00") + "\n");
            
        
        
        }

        static bool primo (int n)
        {
            int con= 0;

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    con++;
                
            }
                
            if (con == 2)
                return true;
            else
                return false;    

        }
            






    }
}
