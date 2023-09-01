/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;
        public float Peso;

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir()
        {
            int distanciaEscuchante = 100;
            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        public void Dormir(int horas)
        {
            if(horas > 10)
            {
                float energiaGanada = 15;
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero
    {
        public string Nombre;
        public string Especialidad;
        public int AñosExperiencia;

        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50;
            if (tipo == "tenis") 
            {
                precio = 100;
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        public void CrearZapato(string estilo, string material)
        {
            for(int i = 0; i < 100; i++)
            {
                if(estilo == "industrial")
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        public void MedirPie(int numeroPie)
        {
            string cliente;
            if (numeroPie > 20) 
            {
                cliente = "Adulto";
            }
            else
            {
                cliente = "Niño";
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television
    {
        public string Marca;
        public int Pulgadas;
        public bool Encendida;

        public void Encender()
        {
            Encendida = true;
            float consumoLuz = 0.05f;
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        public void CambiarCanal(int canal)
        {
            for(int i = 1; i < canal; i++)
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        public void AjustarVolumen(int nivel)
        {
            if (nivel > 100)
            {
                nivel = 0;
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra
    {
        public string Marca;
        public string Tipo;
        public int Cuerdas;

        public void TocarCuerda(int numeroCuerda)
        {
            if(numeroCuerda == 6)
            {
                string nota = "Mi";
            }
            else if (numeroCuerda == 5)
            {
                string nota = "La";
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        public void AfinarGuitarra(bool afinada)
        {
            if (afinada)
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
