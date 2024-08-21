using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite 20 edades y 
            luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            */
            
            Console.WriteLine("\nCalculador de PROMEDIO de edades\n");
            
            int edad, acuEdades = 0, conEdades = 0,promedio;

            Console.WriteLine("Ingrese 20 edades.");
            
            for(int i = 0; i < 20; i++){
                 
                edad = int.Parse(Console.ReadLine());
                
                if (edad > 18){
                    acuEdades+= edad;
                    conEdades++;
                }
            }   
            promedio = acuEdades / conEdades;
            
            Console.WriteLine("\nPERSONAS MAYORES A 18: " + conEdades + "\nPROMEDIO DE EDADES MAYORES A 18: " + promedio);


        }
    }
}
