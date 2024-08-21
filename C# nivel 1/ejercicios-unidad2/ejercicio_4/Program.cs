using System;
using System.Reflection;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado 
            por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por 
            pantalla el sueldo total a cobrar por el mismo.
            */

            float comision, sueldo_fijo, total_facturado, total_cobrar;

            comision = 0.05f; 
            sueldo_fijo = 15000;

            Console.WriteLine("\nIngrese el total facturado: ");
            total_facturado = float.Parse(Console.ReadLine());

            Console.WriteLine("==============================================");

            total_cobrar = (total_facturado*comision) + sueldo_fijo;

            Console.WriteLine("\nSueldo fijo: $" + sueldo_fijo + "\nFacturacion: $" + total_facturado + 
            "\nComision: 5%\nTotal a cobrar: $" +total_cobrar + "\n");




            
        }
    }
}
