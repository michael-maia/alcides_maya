using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Funcionario:Pessoa
	{
		public Int16 turno()
		{
			Int16 opcao=2;
			
			Console.WriteLine("Escolha uma das opções de turno:\n0 - Manhã / Tarde\n1 - Tarde / Noite");
			while(opcao!=0&&opcao!=1) 
			{
				Console.Write("Opção: ");
				opcao=Convert.ToInt16(Console.ReadLine());
				if(opcao!=0&&opcao!=1)
					Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
			}
			
			return opcao;
		}
	}
}
