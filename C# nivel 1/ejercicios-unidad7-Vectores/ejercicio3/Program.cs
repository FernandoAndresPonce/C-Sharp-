using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
             El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
             Mostrar el resultado en pantalla. Ejemplo:
                CADENA FUENTE: “La mar estaba serena"
                CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                CADENA RESULTADO: “Li mir estibi sereni"
            */

            char[] cadenaFuente = new char[30];
            int indice = 0;
            Console.WriteLine("Ingrese la Cadena de Caracteres, y termine con un .(punto).\n");

            cadenaFuente[indice] = char.Parse(Console.ReadLine());
            while (cadenaFuente[indice] != '.' && indice <29)
            {   indice++;
                cadenaFuente[indice] = char.Parse(Console.ReadLine());
                
            }

            if (cadenaFuente[indice] == '.')
                cadenaFuente[indice +1] = '\0';

            Console.Write("CADENA FUENTE: ");
            indice = 0;
            while (cadenaFuente[indice] != '\0'){
                Console.Write(cadenaFuente[indice]);
                indice++;
            }
            Console.WriteLine("\n");
            Console.Write("CADENA RESULTADO: ");
            
            indice = 0;
            while (cadenaFuente[indice] != '\0'){
                if (cadenaFuente[indice] == 'a')
                    cadenaFuente[indice] = 'i';
                
                Console.Write(cadenaFuente[indice]);
                indice++;
            }

                
          
            



        }
    }
}
