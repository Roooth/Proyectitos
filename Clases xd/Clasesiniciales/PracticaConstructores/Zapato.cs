using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Zapato
    {
        private string colorz = "cafe";
        private int talla = 2;

        public Zapato(int valorTalla, string valorColorz)
        { //Este es otro constructor para describir parametros
            talla = valorTalla;
            colorz = valorColorz;
        }
        public void describir()
        {
            Console.WriteLine("Es un zapato de talla " + talla + " de color " + colorz);
        }

    }
}
