using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasAutos
{
    public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

        public void Arrancar()
        {
            if (gasolina > 0)//Si hay gasolina
            {
                //Consume 0.1 litros de gasolina cuando arranca
                gasolina = gasolina - 0.1f;
                Console.WriteLine("Arrancando " + modelo + ",le quedan " + gasolina + "L de gasolina.");
            }
            else 
            {
                Console.WriteLine("No se puede arrancar " + modelo + " sin gasolina.");
            }
        }

        public void PonerGas(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(modelo + " tiene" + gasolina + " L de gasolina.");
        }

        public void Acelerar(int cantidad)
        {
            velocidad = velocidad + cantidad;
            gasolina = gasolina - cantidad / 10;
            Console.WriteLine("El " + modelo + " ha aumentado su velocidad, su velocidad es de " + velocidad + " Km");
            if (gasolina< 0)
            {
                Console.WriteLine("El " + modelo + " se quedo sin gasolina");

            }
            else
            {
                Console.WriteLine("Arrancando " + modelo + ",le quedan " + gasolina + "L de gasolina.");
            }
        }

        public void Frenar()
        {
            velocidad = 0;
            Console.WriteLine("El " + modelo + " ha frenado, su velocidad es de " + velocidad + " Km");
        }
    }
}
