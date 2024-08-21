using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*

            Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            */

            int numeros, conImpar, conPar,  grupo = 0, grupoFinal = 0, numDecre, gruposOrdenados = 0;
            float GrupoMaxPor = 0;
            float imparMAxPor = 0;
            bool barOrdenado;
            
            
            Console.WriteLine("\nINGRESE las 5 listas.\n");

            for (int x = 0; x < 5; x++){
                
                
                numeros = int.Parse(Console.ReadLine());
                
                numDecre=numeros;
                barOrdenado = true;
                conImpar = 0;
                conPar = 0;
               
                while (numeros != 0){
                    // Impares?
                    if (!(numeros % 2 == 0)){
                        conImpar++;
                    }
                    else{
                        conPar++;
                    }
                    
                    
                    // Ordenados de forma Decreciente.
                    
                    if (numDecre >= numeros){
                        numDecre = numeros;
                    }
                    else {
                        barOrdenado = false;
                    }
                    
                    numeros = int.Parse(Console.ReadLine());
                }
                        
                GrupoMaxPor = conImpar*100/(conImpar + conPar);
                grupo = x + 1;
                    

                if (GrupoMaxPor > imparMAxPor){
                    imparMAxPor = GrupoMaxPor;
                    grupoFinal = grupo;
                }
                if (barOrdenado)
                        gruposOrdenados ++;
                
            }
                    
                

            Console.WriteLine("\nGRUPO con MAYOR porcentaje de IMPARES : " + grupoFinal + "\nPORCENTAJE " + imparMAxPor.ToString("0.00") + " %\n");  
        
        
            Console.WriteLine("\nCANTIDAD DE GRUPOS ORDENADOS: " + gruposOrdenados);
        
                    
                    
                    

                

        

                                  
        
                    
                    

        }

    }
}
