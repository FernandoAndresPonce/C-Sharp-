using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Una empresa comercializa 5 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 5)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.
            */

            int[] articulos = new int[5];
            int[] cantidadesVendidas = new int[5];

            int articulo;
            int cantidad;
            
            
            Console.WriteLine("Ingrese los 5 PRODUCTOS. \n");

            for (int i = 0; i < 5; i++)
            {   
                articulo = int.Parse(Console.ReadLine());
                articulos[i] = articulo;
                
            }
            
            Console.WriteLine("Cantiades Vendidas de los 5 PRODUCTOS.\n");

            Console.Write("Ingrese el NUMERO de ARTICULO: ");
            articulo = int.Parse(Console.ReadLine());

            while (articulo != 0)
            {   

                
                for (int i = 0; i < 5; i++)
                {
                    if (articulos[i] == articulo ){

                        Console.Write("Ingrese la CANTIDAD VENDIDA de ese ARTICULO: ");
                        cantidad = int.Parse(Console.ReadLine());
                        cantidadesVendidas[i] += cantidad;
                        
                        
                    }
                  
                    
                }
                
                Console.Write("Ingrese el NUMERO de ARTICULO: ");
                articulo = int.Parse(Console.ReadLine());
            }

                    
            Console.WriteLine("\nCANTIDADES VENDIDAS:  \n");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("PRODUCTO " + articulos[i] + ": " + cantidadesVendidas[i] + " unidades.");
            }
            Console.WriteLine("");
            
            int articuloMasVendido;
            int articuloNumeroMasVendido;
            articuloMasVendido = cantidadesVendidas[0];
            articuloNumeroMasVendido = articulos[0];

        

            for (int i = 1; i < 5; i++)
            {
                if (cantidadesVendidas[i]>articuloMasVendido)
                {
                    articuloMasVendido = cantidadesVendidas[i];
                    articuloNumeroMasVendido = articulos[i];
                }


            }

            Console.WriteLine("ARTICULO MAS VENDIDO: " + articuloNumeroMasVendido + "\n");


            Console.Write("NUMEROS DE ARTICULOS QUE NO REGISTGRARON VENTA: ");
            
            for (int i = 0; i < 5; i++)
            {
                if (cantidadesVendidas[i] == 0){
                    Console.Write(articulos[i] + ", ");
                }
            }
                    

            
                
                
                
                

        }
    }
}

                
                
