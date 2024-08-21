using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            n1 = 7;
            n2 = 9;

            //or

            int n3;
            int n4;

            Console.WriteLine("N1 tiene: " + n1 + " N2 tiene: " + n2);

            Console.WriteLine("\n================================ \n");

            Console.WriteLine("Ingrese un numero: ");

            // Para perdir un dato al usuario usamos.
            Console.ReadLine();

            //Asignarle un valor a una variable que nos da el usuario, y tiene que ser del tipo de dato que estamos solicitando (int, float, charm bool).
            // n3 = Console.ReadLine(); => Esto daria Error.

            // Debemos hacerlo de esta manera.
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            n4 = int.Parse(Console.ReadLine());

            resultado = n3 + n4;

            Console.WriteLine("El resultado es: " + resultado);



            
        }
    }
}
