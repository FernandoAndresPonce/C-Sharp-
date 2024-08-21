using System;
using System.Data;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            */ 

            int n1, n2, n3, n4, min, menor;

            min = 0;
            menor = 0;

            Console.WriteLine("\n=== Ingrese CUANTRO numeros, y le mostrare el MENOR de ellos ===\n");
            
            Console.Write("Primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Tercero numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Cuarto numero: ");
            n4 = int.Parse(Console.ReadLine());

            

            if (n1 < n2){
                if (n1 < n3){
                    if (n1 < n4) {
                        min = n1;
                    }

                }
            }
            else if (n2 < n3) {
                if (n2 < n4){
                    min = n2;
                }
            }
            else {
                if (n3 < n4) {
                    min = n3;
                }
                else {
                    min = n4;
                    }
            } 
            Console.WriteLine("==========================================");
            
            // Optimizar codigo.

            if (n1 < n2 ){
                menor = n1;
            }
            else {
                menor = n2;
            }

            if ( n3 < menor) {
                menor = n3;
            }
            if (n4 < menor){
                menor = n4;
                
            }
            Console.WriteLine("\nMENOR NUMERO: " + min + "\n");

            Console.WriteLine("\nMENOR NUMERO: " + menor + "\n");
        
        }
    }
}
