using System;
using BibliotecaDeLosMetodos;

namespace CalculadoraCientifica_v2
{
	class Program
	{
		static void Main()
		{
			Console.Title = "Calculadora Cientifica Basica";
			string entrada = "";

			do
			{
				Console.Clear();

                Console.WriteLine("\nIngrese la expresion matematica: ");
				Console.WriteLine($"            Expresion ingresada: {Metodos.PreformatearExpresion(entrada)}");
				Console.WriteLine($"                      Resultado: {Metodos.CalcularExpresion(entrada)}");
				Console.WriteLine("\nNomenclatura de una expresion matematica válida: -A+(-B)+(A*B).");
				Console.WriteLine("Esta calculadora soporta lo siguiente: ");
				Console.WriteLine("· operaciones en parentesis \n· operaciones con numeros de signo negativo (-) \n· multiplicacion (*) \n· division (/) \n· suma (+) \n· resta (-).");
				Console.WriteLine("");

				Console.SetCursorPosition(33, 1);
				entrada = Console.ReadLine();
				
			} while (true);
		}
	}
}
