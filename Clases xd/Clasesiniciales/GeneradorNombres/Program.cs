using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Areglos
            string[] InicialNombres = { "Bro", "Pol", "For", "Anc", "Enh", "Gri", "Dar" };
            string[] InicialApellidos = { "ham", "ton", "dunn", "gham", "don", "chester", "field" };
            string[] MesNacimiento = { "Enchanted Fire", "Green Sea", "Deep Mountain", "Devious Souls",
            "Glowing Heat", "Fallen Elders", "Lost Souls" };


            //Aqui estan 3 distintas "ciudades" generadas a partir de los arreglos
            Console.WriteLine("Welcome to " + InicialNombres[0] + InicialApellidos[2] + ", The City Of The " + MesNacimiento[5]);
            Console.WriteLine("Welcome to " + InicialNombres[6] + InicialApellidos[1] + ", The City Of The " + MesNacimiento[3]);
            Console.WriteLine("Welcome to " + InicialNombres[2] + InicialApellidos[4] + ", The City Of The " + MesNacimiento[1]);

            //La instancia generadora con el metodo, la de a de veras
            
            GeneradorCiudad ciudad = new GeneradorCiudad();
            ciudad.generar(1,2,3);

            Console.ReadLine();
        }
    }
}
