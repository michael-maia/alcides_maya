/* NOME: MICHAEL MAIA DA SILVA
 * EMAIL: michaelmdasilva@yahoo.com.br
 */
using System;

namespace Startup
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nome = new string[2000];
			float[] salario = new float[2000];
			float[] custoTotal = new float[2000];
			float totalGeral,totalSalario=0,totalImpostos=0;
			int i,max;
			
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Escreva o nome e o salário separados por ponto e vírgula (;)");
			Console.WriteLine("Formato:\n<Nome>;<Salário>");
			Console.WriteLine("Para sair do programa, escreva 'sair'");
			Console.WriteLine("--------------------------------------------");
			
			for(i=0;i<2000;i++){
				Console.Write("> ");
				string[] input = Console.ReadLine().Split(';');
				nome[i]=input[0].ToUpper();
				if(i==0 && nome[i].ToLower().Equals("sair")){
					Console.WriteLine("\nFIM DO PROGRAMA\nPRESSIONE ENTER PARA SAIR");
					Console.ReadKey();
					return;
				}
				else if(nome[i].ToLower().Equals("sair"))
					break;
				else{
					salario[i]=Math.Abs(float.Parse(input[1]));
					totalSalario+=salario[i];
					totalImpostos+=(salario[i]*(float)0.41);
					custoTotal[i]=salario[i]+(salario[i]*(float)0.41);
				}
			}
			
			max=i;
			totalGeral=totalImpostos+totalSalario;
			Console.WriteLine("\nRESULTADOS INDIVIDUAIS:\n");
			
			for(i=0;i<max;i++){
				Console.WriteLine("Nome: {0}\nINSS: R${1}\t| SegVida: R${2}",nome[i],salario[i]*(float)0.1,salario[i]*(float)0.15);
				Console.WriteLine("VR: R${0}\t| VT: R${1}",salario[i]*(float)0.11,salario[i]*(float)0.05);
				Console.WriteLine("Salário: R${0}\t| Custo Total: R${1}",salario[i],custoTotal[i]);
				Console.WriteLine("--------------------------------------------\n");
			}
			
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("RESULTADOS GERAIS:\n");
			Console.WriteLine("Total dos Impostos: R${0}\nTotal dos Salários: R${1}",totalImpostos,totalSalario);
			Console.WriteLine("Gastos Gerais: R${0}",totalGeral);
			Console.WriteLine("\nFIM DO PROGRAMA\nPRESSIONE ENTER PARA SAIR");
			Console.ReadKey();
		}
	}
}