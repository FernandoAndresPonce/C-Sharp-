using System;
using System.Data;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
            */

            for( int i = 1; i < 11; i++){

                Console.WriteLine(i);
            }

            Console.WriteLine("\n----------------------------------\n");    
        
            int n = 1; 
            while (n < 11) {
                
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
