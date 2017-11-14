using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Aluno2:Pessoa
	{
		public Int16 escolha_turno()
		{
			Int16 opcao_turno=0;
			
			//ESCOLHA DO TURNO
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("\nQual turno você deseja:\n1 - Manhã\n2 - Tarde\n3 - Noite");
			while((opcao_turno<1)||(opcao_turno>3))
			{
				Console.Write("Opção: ");
				opcao_turno=Convert.ToInt16(Console.ReadLine());
				if(opcao_turno<1||opcao_turno>3)
					Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
			}	
			//ESSA ESCOLHA VAI SER SALVA PRA SER USADA NA CLASSE Informatica/ADM
			return opcao_turno;
		}
	}
}

