using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite 20 números y 
            luego emitir por pantalla el máximo de los números pares y 
            el mínimo de los números impares.
            */
            Console.WriteLine("\nNUMEROS PARES Y IMPARES.\n");
            
            int num, maxPar = 0, minImpar = 0;
            bool banderaMaxpar = false;
            bool banderaMinImpar = false;

            Console.WriteLine("Ingrese 20 numeros: \n");
        
            
            for(int i = 0; i < 20; i++){
                
                num = int.Parse(Console.ReadLine());   
                
                if (num % 2 == 0){
                    if (!banderaMaxpar){
                        maxPar = num;
                        banderaMaxpar = true;
                    }
                    else{
                        if(num > maxPar){
                            maxPar = num;
                        }
                    }  

                     
                }
                else {
                    if (!banderaMinImpar){
                        minImpar = num;
                        banderaMinImpar = true;
                    }
                    else{
                        if(num < minImpar){
                            minImpar = num;
                        }
                    }
                }

            }
           
            if (minImpar == 0)
                Console.WriteLine("\nMAXIMO PAR: " + maxPar + "\nMINIMO IMPAR: NO HAY!");
            else if (maxPar == 0)
                Console.WriteLine("\nMAXIMO PAR: NO HAY!"  + "\nMINIMO IMPAR: " + minImpar);
            else
                Console.WriteLine("\nMAXIMO PAR: " + maxPar + "\nMINIMO IMPAR: " + minImpar);

                

        }
    }
}
