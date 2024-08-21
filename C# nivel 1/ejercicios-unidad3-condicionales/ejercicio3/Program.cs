using System;
using System.Reflection;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Una casa de video juegos otorga un descuento dependiendo del importeInicial de la compra 
            realizada según los siguientes valores:

            Si el importeInicial es menor a ARS 1000, no hay descuento.
            Si el importeInicial es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importeInicial es ARS 5000 o más, aplica un descuento del 18%.
            
            */

            float importeInicial, importeFinal;
            
            const float descuento5000 = 0.82f;
            const float descuento1000 = 0.90f;

            Console.Write("\nimporte a Pagar: ARS");
            importeInicial = float.Parse(Console.ReadLine());

            if (importeInicial >= 5000)
                importeFinal = importeInicial * descuento5000;
            
            else if (importeInicial >= 1000)
                importeFinal = importeInicial * descuento1000;
        
            else
                importeFinal = importeInicial;
            

            Console.WriteLine("\nTotal a Pagar: ARS" + importeFinal);

            Console.WriteLine("\n===================================");
            Console.WriteLine("Gracias Por su Compra\n");
        


        }
    }
}
