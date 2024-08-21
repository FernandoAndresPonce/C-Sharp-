using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para ingresar 10 números. 
            El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            */

            Console.WriteLine("\nIngrese 10 numeros, y le mostrare cuantos son PRIMOS.\n");
            
            int primos, conPrimos, conTotal = 0;

            for (int x = 0; x < 10; x++){
                
                Console.Write("Ingrese el numero " + (x + 1) + " :");
                primos = int.Parse(Console.ReadLine());
                
                conPrimos = 0;
                for (int y = 1; y <= primos; y++){
                    if(primos % y == 0){
                        conPrimos++;
                    }
                }
                if (conPrimos == 2){
                    conTotal++;
                    
                }
                
            }
                Console.Write("\nCantidad de PRIMOS: " + conTotal + "\n");

          

            





       
       
        }
    }
}
