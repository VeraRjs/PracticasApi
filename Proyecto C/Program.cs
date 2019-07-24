using System;

namespace Proyecto_C
{
    class Program
    {
        static void Main(string[] args)
        {       
            
        decirNombre(1);
        esPrimo(1);
        Console.WriteLine(esPrimo(1));
        

        DateTime Fecha = new DateTime(1996,09,18);
        Console.WriteLine(DateTime.Today.DayOfWeek);
        Console.WriteLine(queDiaes(Fecha));

        Console.WriteLine("El numero es Perfecto:");
        Console.WriteLine(numPerfecto(8127));
         }
        public static void decirNombre(int a){
            string[] numeros ={"","One","Two","Tree","Four","Five","Six","Seven","Eight","Nine"};
            
            for(int i=1; i<=9; i++){
                
                if(a==i){
                    Console.WriteLine(numeros[a]);
                }
            } 
        }   

        public static bool esPrimo(int numero){
           
            if(numero != 2){ 
            for(int i=2; i<numero; i++){
                if(numero % i == 0){
                    return false;
                } 
            }
            }
            return true;

        } 

        public static string queDiaes(DateTime Fecha){
           
           return Fecha.Date.ToLongDateString();
        
        }

        public static bool numPerfecto(int num){

        int suma = 0;

        for(int i=1; i<num; i++){

            if(num % i== 0){
                suma+=i;
            }
        }
        if (suma == num){

             return true;
        }

        return false;
    

        }

    }
}
