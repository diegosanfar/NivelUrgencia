using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorNumero
{
	class Program
	{
		static void Main(string[] args)
		{
			char d = 's';
			while (d == 's')
			{
				Console.WriteLine("0 - 3: BAIXO." + "\n4 - 6: MÉDIO." + "\n7 - 9: ALTO." + "\nOutros: GRAVE.");
				Console.WriteLine("Informe o nível da urgência:");

				char x = 'a';
				int a = 0;
				while (x == 'a')
				{
					string ab = Console.ReadLine();
					try
					{
						a = Convert.ToInt32(ab);
						x = 'b';
					}
					catch (FormatException)
					{
						Console.WriteLine("Informe uma urgência válida.");
					}
				}

				if (a >= 0 && a <= 3)
				{
					Console.WriteLine("Nível de urgência BAIXO.");
				}
				else if (a > 3 && a <= 6)
				{
					Console.WriteLine("Nível de urgência MÉDIO.");
				}
				else if (a > 6 && a <= 9)
				{
					Console.WriteLine("Nível de urgência ALTO.");
				}
				else
				{
					Console.WriteLine("Nível de urgência GRAVE!");
				}
				Console.WriteLine("Digite s para continuar:");
				d = Convert.ToChar(Console.ReadLine());
			}
			Console.WriteLine("Até mais!");
			Console.ReadLine();
		}

	}
}
