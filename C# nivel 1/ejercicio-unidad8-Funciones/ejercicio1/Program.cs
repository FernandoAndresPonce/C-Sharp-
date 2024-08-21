using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            Usar la función
            */

           
            int cantidadVendida, precio, montoPagar;
            

            Console.Write("\nPRECIO PRODCUTO: " );
            precio = int.Parse(Console.ReadLine());
            Console.Write("");
            Console.Write("CANTIDAD VENDIDA: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            montoPagar = producto(precio, cantidadVendida);

            Console.WriteLine("\nTOTAL A PAGAR: " + montoPagar);

        
        }

        static int producto(int a, int b)
        {   
            int resultado = a * b;
            return resultado;
        }

         

    }    
}