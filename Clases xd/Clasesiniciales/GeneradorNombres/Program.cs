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
            string[] InicialNombres = { "Bro", "Pol", "For", "Anc", "Enh", "Gri", "Dar" };
            string[] InicialApellidos = { "ham", "ton", "dunn", "gham", "don", "chester", "field" };
            string[] MesNacimiento = { "Enchanted Fire", "Green Sea", "Deep Mountain", "Devious Souls",
            "Glowing Heat", "Fallen Elders", "Lost Souls" };


            
            Console.WriteLine("Welcome to " + InicialNombres[0] + InicialApellidos[2] + " , The City Of The " + MesNacimiento[5]);
            Console.ReadLine();
        }
    }
}
