using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Contacto
    {
        private string nombre = "Emergencias";
        private int numero = 911;

        public Contacto(string nomContacto, int numTelefono)
        { //Este es otro constructor para describir parametros
            nombre = nomContacto;
            numero = numTelefono;
        }
        public void llamar()
        {
            Console.WriteLine("Lammando a " + nombre + " por el numero telefonico de:  " + numero);
        }
    }
}
