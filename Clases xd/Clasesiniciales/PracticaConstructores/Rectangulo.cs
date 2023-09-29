using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Rectangulo
    {
        private float baserec;
        private float alturarec;

        public Rectangulo(float bRectangulo, float aRectangulo)
        { //Este es otro constructor para describir parametros
            baserec = bRectangulo;
            alturarec = aRectangulo;
        }

        public float calPerimetro()
        {
            return baserec + alturarec + baserec + alturarec;
        }
    }
}
