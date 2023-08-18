using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras Ferrari = new AutoCarreras();
            Ferrari.modelo = "Ferrari F150";
            Ferrari.peso = 1.3f;
            Ferrari.velocidad = 230;//son km 

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren M57";
            mcLaren.peso = 0.9f;
            mcLaren.velocidad = 280;//son km

            AutoCarreras Miata = new AutoCarreras();
            Miata.modelo = "Mazda MX-5";
            Miata.peso = 0.9f;
            Miata.velocidad = 320;//son km

            PistaDeCarreras hnoRodriguez = new PistaDeCarreras();
            hnoRodriguez.nombre = "Autodromo Hermanos Rodriguez";
            hnoRodriguez.longitud = 5.6f;

            //mando a competir estos coches
            hnoRodriguez.Competir(Ferrari, Miata);

            //espera a enter para continuar
            Console.ReadLine();
        }
    }
}
