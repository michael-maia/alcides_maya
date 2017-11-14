using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Informatica:Aluno2
	{
		public void grade_curricular_inf()
		{
			Console.WriteLine("\nSua grade curricular será a seguinte:");
			Console.WriteLine("Módulo 1:\n\t- Lógica de Programação\n\t- HTML");
			Console.WriteLine("Módulo 2:\n\t- Banco de Dados\n\t- Tecnologia Wireless");
		}
		
		public void situacao_inf(Int16 opcao_turno)
		{
			Console.WriteLine("---------------------------------------------------------------");
			Random rnd = new Random();
			Int16[] codigo_mat=new Int16[6]{0,0,0,0,0,0};
			Int16 i;
			Console.WriteLine("INFORMAÇÕES DA SUA MATRÍCULA\nCurso: Técnico em Informática");
			Console.Write("Código de Matrícula: 0");
			for(i=1;i<6;i++)
			{
				codigo_mat[i]=Convert.ToInt16(rnd.Next(0,10));
				Console.Write(codigo_mat[i]);
			}
			switch(opcao_turno)
			{
					case 1: Console.WriteLine("\nTURMA: 1M1");break;
					case 2: Console.WriteLine("\nTURMA: 1T1");break;
					case 3: Console.WriteLine("\nTURMA: 1N1");break;
			}
			
		}
	}
}
