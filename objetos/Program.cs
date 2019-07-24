using System;

namespace objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Alison = new Estudiante();
            Alison.mostrarEdad(17);

            var Paula = new Estudiante();
            Paula.mostrarEdad(18);

            var Aguilar = new Maestro();
            Aguilar.decirHola();
            Aguilar.explicar();

        }
    }

    class Persona
    {
        public int edad {get; private set;}
        public void setedad(int numero){
          this.edad=numero;
        }

     public void decirHola(){
        Console.WriteLine("Hola ,¿como estan?");
        }
    }

    class Maestro:Persona
    {
           public void explicar(){
               Console.WriteLine("Comienzo a explicar");
           }

           private string subject{get; set;}
        
    }
    class Estudiante:Persona
    {
        public void mostrarEdad(int numero){
            Console.WriteLine(numero);
        }
    }
}
