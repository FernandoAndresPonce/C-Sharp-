using System;

namespace condicional_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 45;

            int edad2 = 20;

            

            if (edad > 21 ) {
                if (edad > 30){
                    Console.WriteLine("30% OFF");

                }
                else{
                    Console.WriteLine("21% OFF");
                }     

            }
            else {
                Console.WriteLine("10% OFF");
            }


            Console.WriteLine("=================================");
            
            
            if (edad2 > 30 )
                Console.WriteLine("30% OFF");

            else if (edad2 > 20)
                Console.WriteLine("21% OFF");

            else
                Console.WriteLine("10% OFF");
                     
            Console.WriteLine("Fin del programa");
    
        }
    }
}
