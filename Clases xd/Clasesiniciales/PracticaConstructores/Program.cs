using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon();
            dragon1.presentarse();
            float velocidad = dragon1.calVelocidad();
            Console.WriteLine("Velocidad: " + velocidad);

            Dragon dragon2 = new Dragon("electrico", "amarillo");
            dragon2.presentarse();
            Console.WriteLine("Velocidad: " + dragon2.calVelocidad());

            Dragon dragon3 = new Dragon("roca", "blanco");
            dragon3.presentarse();

            //Aqui estan los ejercicios de clase, las 5 clases

            Console.WriteLine();//Una linea vacia para separar un poco xd

            Triangulo triangulo = new Triangulo(12, 6);
            float area = triangulo.calArea();
            Console.WriteLine("El area de este triangulo es de: " + area);

            Triangulo triangulo2 = new Triangulo(21, 7);         
            Console.WriteLine("El area de este triangulo es de: " + triangulo2.calArea());

            Console.WriteLine();//Sigue el rectangulo

            Rectangulo rectangulo = new Rectangulo(11, 5);
            float perimetro = rectangulo.calPerimetro();
            Console.WriteLine("El perimetro de este rectangulo es de: " + perimetro);

            Rectangulo rectangulo2 = new Rectangulo(1, 3);
            
            Console.WriteLine("El perimetro de este rectangulo es de: " + rectangulo2.calPerimetro());

            Console.WriteLine();//Sigue el zapato

            Zapato zapato = new Zapato(5, "cafe");
            zapato.describir();

            Zapato zapato2 = new Zapato(2, "rosa");
            zapato2.describir();

            Console.WriteLine();//Sigue el foco

            Foco foco1 = new Foco(256, true);
            float consumismo = foco1.calConsumo();
            Console.WriteLine("El consumo de este foco es de: " + foco1.calConsumo() + " Watts");

            Foco foco2 = new Foco(152, false);
            Console.WriteLine("El consumo de este foco es de: " + foco2.calConsumo() + " Watts");

            Console.WriteLine();//Sigue el contacto

            Contacto contacto1 = new Contacto("Poli", 911);
            contacto1.llamar();

            Contacto contacto2 = new Contacto("Emma", 222667454);
            contacto2.llamar();



            Console.ReadLine();

        }
    }
}
