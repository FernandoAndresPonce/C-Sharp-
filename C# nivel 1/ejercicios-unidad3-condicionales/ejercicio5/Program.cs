using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            */
        
            int a, b, c ,d ,con;

            con = 0;

            Console.WriteLine("\nIngrese CUATRO numeros, y le dire cual o cuales son MAYORES A 100.\n");

            Console.Write("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero: ");
            d = int.Parse(Console.ReadLine());

            Console.Write("");

            if ( a > 100) {
                Console.Write(a + ", ");
                con++;
            }
            if (b > 100){
                Console.Write(b+ ", ");
                con++;
            }
            if (c > 100){
                Console.Write(c+ ", ");
                con++;
            }
            if (d > 100){
                Console.Write(d+ ", ");
                con++;
            }

            if ( con != 0){
                Console.WriteLine("son mayores a 100..");
            }
            else {
                Console.WriteLine("\nNo hay numeros mayores a 100\n");
            }

            Console.WriteLine("Fin del programa\n");
            

            

            
        
               
        }

    }
}
