using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Pedagogico:Funcionario
	{
		Int16[] codigo_func=new Int16[8];
		public void situacao_pedagogico(Int16 opcao_turno)
		{
			Console.WriteLine("---------------------------------------------------------------");
			Random rnd = new Random();
			Int16[] codigo_func=new Int16[8]{1,0,0,0,0,0,0,0};
			Int16 x=2,i;
			this.codigo_func=codigo_func;
			Console.WriteLine("Você é professor de qual curso?\n0 - Téc. em Informática\n1 - Téc. em ADM");
			while(x!=0&&x!=1) 
			{
				Console.Write("Opção: ");
				x=Convert.ToInt16(Console.ReadLine());
				if(x!=0&&x!=1)
					Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
			}
			if(x==0)
				codigo_func[1]=0;
			else
				codigo_func[1]=1;
			codigo_func[2]=opcao_turno;
			for(i=3;i<8;i++)
			{
				codigo_func[i]=Convert.ToInt16(rnd.Next(0,10));
			}
		
		}
		public void exibir()
		{
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("INFORMAÇÕES DO FUNCIONÁRIO:");
			Int16 i;
			Console.Write("Código de Funcionário: ");
			for(i=0;i<8;i++)
			{
				Console.Write(codigo_func[i]);
			}
			switch(codigo_func[1])
			{
					case 0: Console.WriteLine("\nProfessor de Técnico de Informática");break;
					case 1: Console.WriteLine("\nProfessor de Técnico de Administração");break;
			}
			switch(codigo_func[2])
			{
					case 0: Console.WriteLine("SUAS TURMAS: 1M1 / 1T1");break;
					case 1: Console.WriteLine("SUAS TURMAS: 1T2 / 1N3");break;
			}
			Console.WriteLine("SALÁRIO: R$2000,00");
		}
			
	
		
		
		
	}
}
