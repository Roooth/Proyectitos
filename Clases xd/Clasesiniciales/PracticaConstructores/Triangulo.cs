using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Triangulo
    {
        private float basetri;
        private float alturatri;

        public Triangulo(float bTriangulo, float aTriangulo)
        { //Este es otro constructor para describir parametros
            basetri = bTriangulo;
            alturatri = aTriangulo;
        }

        public float calArea()
        {
            return basetri * alturatri / 2;
        }
    }
}
