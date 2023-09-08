using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombres
{
    class GeneradorCiudad
    {
        public string[] InicialNombres = { "Bro", "Pol", "For", "Anc", "Enh", "Gri", "Dar","Col", "Mol", "Rot", "Gre", "Blu","Cre",
                                           "Gol", "Nol", "Sou", "Eas", "Wes", "Sil", "Lit", "Clo", "Cal", "Sle", "Spl", "Gla", "Sal"};
        public string[] InicialApellidos = { "ham", "ton", "dunn", "gham", "don", "chester", "field", "pool", "york", "dam", "yo", "hal", "ray"
                                            ,"rachi", "bul", "hagen", "bourne", "lin", "ris", "end", "to", "rid", "enna", "co", "bing", "burgh"};
        public string[] MesNacimiento = { "Enchanted Fire", "Green Sea", "Deep Mountain", "Devious Souls","Glowing Heat", "Fallen Elders"
                , "Lost Souls", "Royal Witches", "Shallow Fox", "Rotten Fruit", "Golden Rock", "Mystic Warriors" };

        public void generar(int nombre,int apellido,int mes) 
        {
            if (nombre > 26) { Console.WriteLine("ERROR"); }
            if (apellido > 26) { Console.WriteLine("ERROR"); }
            if (mes > 12) { Console.WriteLine("ERROR"); }
            Console.WriteLine("Welcome to " + InicialNombres[nombre - 1] + InicialApellidos[apellido -1] + ", The City Of The " + MesNacimiento[mes - 1]);
        }

    }
}
