using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
namespace Escola
{
	class ADM:Aluno2
	{
		public void grade_curricular_adm()
		{
			Console.WriteLine("\nSua grade curricular será a seguinte:");
			Console.WriteLine("Módulo 1:\n\t- Matemática Financeira\n\t- Recursos Humanos");
			Console.WriteLine("Módulo 2:\n\t- Contabilidade\n\t- Marketing Organizacional");
		}
		
		public void situacao_adm(Int16 opcao_turno)
		{
			Console.WriteLine("---------------------------------------------------------------");
			Random rnd = new Random();
			Int16[] codigo_mat=new Int16[6]{0,0,0,0,0,0};
			Int16 i;
			//GERA UM CODIGO ALEATORIO DE MATRICULA QUE COMEÇA SEMPRE COM ZERO
			Console.WriteLine("INFORMAÇÕES DA SUA MATRÍCULA\nCurso: Técnico em Administração");
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
