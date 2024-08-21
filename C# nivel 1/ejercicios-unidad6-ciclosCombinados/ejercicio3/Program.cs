using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            */

            int n, conCantNumeros,conLista, nrolista;


            // Console.WriteLine ("Ingrese una lista: .0 EMPEZAR . FINLIZAR ");
            // n = int.Parse(Console.ReadLine());
            
            // //lote
            // conLista = 0;    
            // while (n == 0 ){
            //     conLista++;
            //     nrolista = conLista;

            //     //sublote
            //     n = int.Parse(Console.ReadLine());
            //     conCantNumeros = 0;
            //     while (n > 0){
            //         conCantNumeros++;

            //     n = int.Parse(Console.ReadLine());
            //     }

            //     Console.WriteLine("\nLista: " + nrolista + "\nCantidad de numeros POSITIVOS: " + conCantNumeros);
            // }

            Console.WriteLine ("Ingrese una lista: ");
            conLista = 0;
            do
            {   
                conLista++;
                nrolista = conLista;

                //sublote
                n = int.Parse(Console.ReadLine());
                conCantNumeros = 0;
                while (n > 0){
                    conCantNumeros++;

                n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nLista: " + nrolista + "\nCantidad de numeros POSITIVOS: " + conCantNumeros);
                
            } while (n >= 0);

            
        
        
        }
    }
}
