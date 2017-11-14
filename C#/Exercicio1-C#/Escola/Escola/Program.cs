using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Program
	{
		public static void Main(string[] args)
		{
			Int16 escolha0=2;
			//ESCOLHA ENTRE ALUNO E FUNCIONARIO
			Console.WriteLine("Você é:\n0 - Aluno\n1 - Funcionário");
			while(escolha0!=0&&escolha0!=1)
			{
				Console.Write("Opção: ");
				escolha0=Convert.ToInt16(Console.ReadLine());
				if(escolha0!=0&&escolha0!=1)
					Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
			}
			
			//CASO 0: É UM ALUNO
			if(escolha0==0)
			{
				Int16 escolha1=2;
				Double valor_inf=5000.00,valor_adm=4400.00;;
				Console.WriteLine("\nEscolha o seu curso:\n\n0 - Técnico em Informática\nValores:");
				Console.WriteLine("\t1 x {0}\n\t7 x {1}\n\t14 x {2}",valor_inf,Math.Round((valor_inf/7.0),2),Math.Round((valor_inf/14.0),2));
				Console.WriteLine("Carga Horária: 1200h + 400h de Estágio");
				Console.WriteLine("---------------------------------------");
				Console.WriteLine("1 - Técnico em Administração\nValores:");
				Console.WriteLine("\t1 x {0}\n\t7 x {1}\n\t14 x {2}",valor_adm,Math.Round((valor_adm/7.0),2),Math.Round((valor_adm/14.0),2));					Console.WriteLine("Carga Horária: 1020h + 400h de Estágio");
				while(escolha1!=0&&escolha1!=1) //MOSTRA OS CURSOS DISPONIVEIS
				{
					Console.Write("\nOpção: ");
					escolha1=Convert.ToInt16(Console.ReadLine());
					if(escolha1!=0&&escolha1!=1)
						Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
				}
				//ESCOLHEU INFORMATICA
				if(escolha1==0)
				{
					Informatica user=new Informatica();
					Int16 auxiliar;
					//CLASSE Pessoa
					user.info_pessoal();
					//CLASSE Aluno
					auxiliar=user.escolha_turno();
					//CLASSE Informatica
					user.situacao_inf(auxiliar);
					user.grade_curricular_inf();
					//CLASSE Pessoa
					user.exibir_info();
					
				}
				else //ESCOLHEU ADMINISTRACAO
				{
					Int16 auxiliar;
					ADM user=new ADM();
					//CLASSE Pessoa
					user.info_pessoal();
					//CLASSE Aluno
					auxiliar=user.escolha_turno();
					//CLASSE ADM
					user.situacao_adm(auxiliar);
					user.grade_curricular_adm();
					//CLASSE Pessoa
					user.exibir_info();
				}
			}
			else //CASO 1: É UM FUNCIONARIO
			{
				Int16 escolha1=2;
				Console.WriteLine("\nVocê é:\n0 - Professor\n1 - Vendedor");
				while(escolha1!=0&&escolha1!=1) 
				{
					Console.Write("\nOpção: ");
					escolha1=Convert.ToInt16(Console.ReadLine());
					if(escolha1!=0&&escolha1!=1)
						Console.WriteLine("Você digitou uma opção inexistente, tente novamente!");
				}
				//É UM PROFESSOR
				if(escolha1==0)
				{
					Int16 auxiliar2;
					Pedagogico user=new Pedagogico();
					user.info_pessoal();
					auxiliar2=user.turno();
					user.situacao_pedagogico(auxiliar2);
					user.exibir();
					user.exibir_info();
					
				}
				else //É UM VENDEDOR
				{
					Int16 auxiliar2;
					Comercial user=new Comercial();
					user.info_pessoal();
					auxiliar2=user.turno();
					user.situacao_comercial(auxiliar2);
					user.exibir();
					user.exibir_info();					
				}
			}
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}