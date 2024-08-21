using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.*/
        
            
            // 1= int max =0 , posicion = 0;
            

            int[] vector = new int[10];
            int max = vector[0], posicion = 1;

            Console.WriteLine("\nIngrese 10 numeros, y le dire cual es el VALOR MAXIMO y en que POSICION.\n");
            Console.WriteLine("Numeros a Ingresar: \n");
            for (int x = 0; x < 10; x++){

                 
                vector[x] = int.Parse(Console.ReadLine());

                if (vector[x] > max){
                    max = vector[x];
                    posicion = x + 1;

                    
                }
            }
            

            // 1= for (int y = 0; y < 10; y++){
                 

            //     if (y == 0){
            //         max = vector[y];
            //         posicion = y + 1;
            //     }
            //     else {
            //         if (vector[y] > max){
            //             max = vector[y];
            //             posicion = y + 1;

            //         }
            //     }
            // }

            Console.WriteLine("\nValor Maximo: " + max + "\nPosicion: " + posicion);
           


        
        }
    }
}



        
        
        
        
            
