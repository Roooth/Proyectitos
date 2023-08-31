/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System;

namespace ClasesYMetodosAnidados
{//Identacion: 0, Inicio de bloque de namespace ClasesYMetodosAnidados
	class Program //Identacion: 1
	{
		static void Main(string[] args)
		{
			ClaseA objetoA = new ClaseA();//Identacion: 3
			ClaseB objetoB = new ClaseB();

			objetoA.Metodo1();
			objetoA.Metodo2();

			objetoB.Metodo1();
			objetoB.Metodo2();
		}
	}

	class ClaseA
	{
		public void Metodo1()
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);

				for (int j = 0; j < 2; j++)
				{
					Console.WriteLine("Ciclo anidado - Iteración: " + j);
				}
			}
		}

		public void Metodo2()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
			{
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA");
			}
			else
			{
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");
			}
		}
	}

	class ClaseB
	{
		public void Metodo1()
		{
			for (int i = 5; i > 0; i--)
			{
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i);

				for (int j = 0; j < i; j++)
				{
					Console.WriteLine("Ciclo anidado - Iteración: " + j);
				}
			}
		}

		public void Metodo2()
		{
			int numero = 10;

			if (numero % 2 == 0)
			{
				Console.WriteLine("El número es par en Método 2 de ClaseB");
			}
			else
			{
				Console.WriteLine("El número es impar en Método 2 de ClaseB");
			}
		}
	}
}