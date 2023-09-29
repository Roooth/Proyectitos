using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Foco
    {
        //calcular consumo, si esta encendido devolver la cantidad de watts y si no mandar 0
        private float watts;
        private bool prendido = true;

        public Foco(float consumo, bool encendido)
        { //Este es otro constructor para describir parametros
            watts = consumo;
            prendido = encendido;
        }

        public float calConsumo()
        {
            if (prendido == true)
            {
                return watts;
            }

            else
            {
                return 0;
            }
        }
    }
}
