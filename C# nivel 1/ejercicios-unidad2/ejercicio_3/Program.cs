using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
             Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            
            */

            float  km_dos_ciudades, velocidad_promedio;
            float tiempo_demora;
            int horas, minutos, segundos;


            Console.WriteLine("Ingrese los kilometros entre las dos ciudades: ");
            km_dos_ciudades = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su velocidad promedio: ");
            velocidad_promedio = float.Parse(Console.ReadLine());

            tiempo_demora = (km_dos_ciudades / velocidad_promedio)*60;

            

            Console.WriteLine("La distancia que debe recorrer son " + km_dos_ciudades + 
            "km. a una velocidad promedio de " + velocidad_promedio + "km/h, llegara a su destino en " + tiempo_demora + " minutos.");

            
            tiempo_demora = km_dos_ciudades / velocidad_promedio;

            Console.WriteLine("La distancia que debe recorrer son " + km_dos_ciudades + 
            "km. a una velocidad promedio de " + velocidad_promedio + "km/h, llegara a su destino en " + tiempo_demora.ToString("0.00") + " horas.");
            

            tiempo_demora = km_dos_ciudades / velocidad_promedio;

            horas = (int)tiempo_demora;

            minutos = (int)((tiempo_demora - horas)*60);

            segundos = (int)((((tiempo_demora - horas)*60) - minutos)*60);

            Console.WriteLine("La distancia que debe recorrer son " + km_dos_ciudades + 
            "km. a una velocidad promedio de " + velocidad_promedio + "km/h, llegara a su destino en " 
            + horas + " horas " + minutos + " minutos y " + segundos + " segundos.");
            
            
            

            
        }
    }
}
