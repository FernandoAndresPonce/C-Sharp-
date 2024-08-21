using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer una función de tipo void (porque no va a devolver nada)
            llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            Que analice el número y escriba variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.
            */

            int numero;
            int resultado = 0;

            Console.WriteLine("\nINGRESE UN NUMERO, Y LE DIRE SI POSITIVO,  NEGATIVO O UN CERO: \n");
            positivoNegativoCero(numero = int.Parse(Console.ReadLine()), ref resultado);

            Console.WriteLine("\nEL NUMERO ES: " + resultado + "\n");


        }
        static void positivoNegativoCero(int a, ref int b)
        {   

            if( a > 0)
                b = 1;
            else if( a < 0)
                b = -1;
            else
                b = 0;

        }

                
    }
}
