using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Dragon
    {
        private string tipo = "hielo";
        private string color = "gris";
        private int cantAlas = 4;
        private float peso = 25000;

        public Dragon()
        {
            //Este es un constructor
                //Estableciendo el estado
                //Inicial del objeto
            tipo = "fuego";
        }

        public Dragon(string valorTipo,string valorColor)
        { //Este es otro constructor para describir parametros
            tipo = valorTipo;
            color = valorColor;
        }

        public void presentarse()
        {
            Console.WriteLine("Yo soy un dragon de " + tipo + " color " + color + " y voy a comerlos a todos");
        }

        public float calVelocidad()
        {
            return cantAlas / peso ;
        }
    }
}
