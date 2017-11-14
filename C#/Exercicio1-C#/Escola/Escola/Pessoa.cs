using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Pessoa:Program
	{
		String nome,idade,cidade,bairro,logradouro,numero,cpf;
						
		//CADASTRO DE INFORMACOES
		public void info_pessoal()
		{
			Console.WriteLine("---------------------------------------------------------------");
			Console.Write("Nome: "); String nome=Console.ReadLine();
			Console.Write("Idade: "); String idade=Console.ReadLine();
			Console.Write("Cidade: "); String cidade=Console.ReadLine();
			Console.Write("Bairro: "); String bairro=Console.ReadLine();
			Console.Write("Logradouro: "); String logradouro=Console.ReadLine();
			Console.Write("Número: "); String numero=Console.ReadLine();
			Console.Write("CPF: "); String cpf=Console.ReadLine();
			
			this.nome=nome;	this.idade=idade; this.cidade=cidade; this.bairro=bairro;
			this.logradouro=logradouro;	this.numero=numero;	this.cpf=cpf;
		}
		
		
		public void exibir_info()
		{
			Console.WriteLine("Nome: "+nome);
			Console.WriteLine("Idade: "+idade);
			Console.WriteLine("Cidade: "+cidade);
			Console.WriteLine("Bairro: "+bairro);
			Console.WriteLine("Logradouro: "+logradouro);
			Console.WriteLine("Número: "+numero);
			Console.WriteLine("CPF: "+cpf);
		}
		
		
	}
}
