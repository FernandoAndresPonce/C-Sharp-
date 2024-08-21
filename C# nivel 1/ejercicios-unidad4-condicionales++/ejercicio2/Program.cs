using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos 
            según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            Hacer un programa que solicite el ingreso del importe total de la venta y 
            la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            
            */

            float litros, precioTotalPagar, precioFinal;
            
            const float precioXlitro = 1;
            

            const float desc500 = 0.75f;
            const float desc300 = 0.85f;
            const float desc100 = 0.90f;

            Console.Write("Ingrese la CANTIDAD de litros: ");
            litros = float.Parse(Console.ReadLine());

            if (litros > 500)
                precioFinal = precioXlitro * desc500;
                
            else if (litros > 300)
                precioFinal = precioXlitro * desc300;
                
             else if (litros > 100)
                precioFinal = precioXlitro * desc100;
                
            else 
                precioFinal = precioXlitro;
            

            precioTotalPagar = litros * precioFinal;

            Console.WriteLine("\nPrecio X litro: $" + precioXlitro +
            "\nPrecio X Litro CON descuento: " + precioFinal +
            "\nLitros: " + litros +"L" + 
            "\nPrecio FINAL: $" + precioTotalPagar.ToString("0.00") + "\n");

        }
    }
}
