using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
             Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            */
            Console.WriteLine("\nNUMERO PRIMO O NO\n");

            int num, con = 0;
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++){
                if (num % i == 0)
                    con++;
                
            }

            if (con == 2)
                Console.WriteLine("\nNUMERO PRIMO\n");
            else
                Console.WriteLine("\nNUMERO NO PRIMO\n");
            

        }
    }
}
