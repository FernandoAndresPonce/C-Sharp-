using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
            Para ello existe la siguiente escala de precios:

                        i5 (1)	i7 (2)	i9 (3)
            8 RAM (1)	USD 800	USD 900	USD 1200
            16 RAM (2)	USD 900	USD 1000	USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000
            Además, el equipo viene con un disco que permite almacenar 500 GB de información y 
            que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
            (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            
            */
            int procesador, ram =0, disco;
            float totalPagar=0;
            String componenteProcesador = ""; String componenteRam = ""; String componenteDisco = "";

            Console.WriteLine("Arme su Computadora.");
            

            Console.WriteLine("Procesadores. \n1.i5\n2.i7\n3.i9");
            procesador = int.Parse(Console.ReadLine());



            

            switch (procesador){
                case 1:
                    componenteProcesador = "i5";
                    
                    Console.WriteLine("Procesadores. \n1.8RAM\n2.16RAM\n3.32RAM"); 
                    ram = int.Parse(Console.ReadLine());

                    switch (ram){
                        case 1:
                            totalPagar = 800;
                            componenteRam = "8RAM";

                            
                        break;
                        
                        case 2:
                            totalPagar = 900;
                            componenteRam = "16RAM";
                        break;

                        case 3:
                            totalPagar = 1000;
                            componenteRam = "32RAM";
                        break;

                        default:
                            Console.WriteLine("\nOpcion incorrecta.\nVuelva a intentarlo.");
                        break;
                    }
                break;

                case 2:
                    componenteProcesador = "i7";
                    Console.WriteLine("Procesadores. \n1.8RAM\n2.16RAM\n3.32RAM"); 
                    ram = int.Parse(Console.ReadLine());

                    switch (ram){
                        case 1:
                            totalPagar = 900;
                            componenteRam = "8RAM";
                        break;

                        case 2:
                            totalPagar = 1000;
                             componenteRam = "16RAM";
                        break;

                        case 3:
                            totalPagar = 1400;
                            componenteRam = "32RAM";
                        break;
                    
                        default:
                            Console.WriteLine("\nOpcion incorrecta.\nVuelva a intentarlo.");
                        break;
                    }
                break;
                
                case 3:
                    componenteProcesador = "i9";
                    Console.WriteLine("Procesadores. \n1.8RAM\n2.16RAM\n3.32RAM"); 
                    ram = int.Parse(Console.ReadLine());

                    switch (ram){
                        case 1:
                            totalPagar = 1200; 
                            componenteRam = "8RAM";
                        break;

                        case 2:
                            totalPagar = 1400;
                            componenteRam = "16RAM";
                        break;
                    
                        case 3:
                            totalPagar = 2000;
                            componenteRam = "32RAM";
                        break;
                    
                        default:
                            Console.WriteLine("\nOpcion incorrecta.\nVuelva a intentarlo.");
                        break;
                    }
                break;

                default:
                            Console.WriteLine("\nOpcion incorrecta.\nVuelva a intentarlo.");
                break;
            }
            

            if ((procesador == 1 || procesador == 2 || procesador == 3) && (ram == 1 || ram == 2 || ram == 3)){
                Console.WriteLine("\nDesea extender su Disco Rigido a 1TB.\n1.Si\n2.No");
                disco = int.Parse(Console.ReadLine());

                
                switch (disco){
                    case 1:
                        totalPagar += 300;
                        componenteDisco = "1TB";
                    break;

                    case 2:
                        Console.WriteLine("\nNo desea expandir el Disco Rigido.");
                        componenteDisco = "500GB";
                    break;

                    default:
                        Console.WriteLine("\nOpcion incorrecta.\nVuelva a intentarlo.");
                    break;
                }


                Console.WriteLine("\nPROCESADOR: " + componenteProcesador  + 
                "\nRAM: " + componenteRam + 
                "\nDISCO RIGIDO: " + componenteDisco + 
                "\nTotal a Pagar: " + totalPagar + "\n");

        

            }        

            

            

            
        }
    }
}







                
                    



                        

              
                        


                



                        
                    

                            

