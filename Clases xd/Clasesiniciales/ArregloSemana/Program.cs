using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es un arreglo de strings con declaracion explicita
            string[] diasSemana = { "Domingo", "Lunes","Martes",
                "Miercoles", "Jueves", 
                "Viernes", "Sabado" };
            int cantDias = diasSemana.Length;

            Console.WriteLine("Hay " + cantDias + " dias en el arreglo");

            //Asigno un valor en el arreglo
            diasSemana[1] = "Monday";

            //Accedo a un elemento y lo guardo en una variable
            string diaUno = diasSemana[1];
            string diaTres = diasSemana[3];

            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);
            //Accedo a un elemento y lo uso directamente
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            for(int i = 0; i < diasSemana.Length; i++)//ciclo parametrizado
            {
                //Uso la variable de contol i para acceder a cada elemento del arreglo
                Console.WriteLine(i + ".-" + diasSemana[i]);

            }

            Console.ReadLine();

        }
    }
}
