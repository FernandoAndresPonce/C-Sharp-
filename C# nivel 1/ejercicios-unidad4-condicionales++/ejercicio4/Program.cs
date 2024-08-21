using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            */

            int num1, num2, num3;

            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 + num2 > num2 * num3)
                Console.WriteLine("La suma de los dos primeros es MAYOR al producto del segundo con el tercero.");
            else if (num1 + num2 == num2 * num3)
                Console.WriteLine("La suma de los dos primeros es IGUAL al producto del segundo con el tercero.");
            else 
                Console.WriteLine("La suma de los dos primeros es MENOR al producto del segundo con el tercero.");

            

           
            


        }
    }
}
