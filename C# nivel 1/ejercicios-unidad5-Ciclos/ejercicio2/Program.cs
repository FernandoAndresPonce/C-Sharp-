using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite el ingreso de 10 números 
            y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            */

            // int numero;
            // int mayor = 0;
            
            // Console.WriteLine("\ningrese 10 numeros, y le imprimiri el MAYOR de ellos: \n");
            
            // for (int i = 0; i < 10; i++){
            
            //     numero = int.Parse(Console.ReadLine());
            //     if (numero > mayor)
            //             mayor = numero;
                    
            
            // }

            // Console.WriteLine("El numero MAYOR es: " + mayor);
            
            
            int numero;
            int mayor;
    
            bool banMayor = false;

            
            Console.WriteLine("\ningrese 10 numeros, y le imprimiri el MAYOR de ellos: \n");
            numero = int.Parse(Console.ReadLine());
            mayor = 0;
            
            
            
            for (int i = 0; i < 10; i++){
            
                numero = int.Parse(Console.ReadLine());
                
                if (!banMayor){
                    mayor = numero;
                    banMayor = true;
                }
                else  
                    if (numero > mayor)
                        mayor = numero;
            }

            Console.WriteLine("El numero MAYOR es: " + mayor);
                    
            


            // int numero; int mayor = 0;
            // int i = 0;
            // int pos = 0;

            // Console.WriteLine("\ningrese 10 numeros, y le imprimiri el MAYOR de ellos: \n");

            // while ( i < 10){
            
            //     numero = int.Parse(Console.ReadLine());
            //     if (numero > mayor){
            //         mayor = numero;
            //         pos = i + 1  ;
            //     }
            //     i++;    
            // }
            // Console.WriteLine("El numero MAYOR es: " + mayor + " " + pos);

                




        }
    }
}
