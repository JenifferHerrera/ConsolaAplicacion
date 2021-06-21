using System;

namespace ConsolaAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tira Comica Popeye!");

            var personaje = new Plevello
            {
                Nombre = "Popeye",
                trabajo = "Explorador",
                pobre = "economia baja",
                familia = "5"

            };
            Console.WriteLine(personaje.Caminar());


            Obstaculo obstaculo = new Obstaculo
            {
                Nombre = "dragones"
            };

            Obstaculo obstaculo1 = new Obstaculo
            {
                Nombre = "fuego"
            };

            Obstaculo obstaculo2 = new Obstaculo
            {
                Nombre = "agua"
            };

            Obstaculo obstaculo3 = new Obstaculo
            {
                Nombre = "pentes colgantes"
            };

            Obstaculo obstaculo4 = new Obstaculo
            {
                Nombre = "precipicios"
            };

        }
    }
}
