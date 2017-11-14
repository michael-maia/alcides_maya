using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
	class Comercial:Funcionario
	{
		Int16[] codigo_func=new Int16[8];
		public void situacao_comercial(Int16 opcao_turno)
		{
			Console.WriteLine("---------------------------------------------------------------");
			Random rnd = new Random();
			Int16[] codigo_func=new Int16[8]{2,1,0,0,0,0,0,0};
			Int16 i;
			this.codigo_func=codigo_func;
			codigo_func[2]=opcao_turno;
			for(i=3;i<8;i++)
			{
				codigo_func[i]=Convert.ToInt16(rnd.Next(0,10));
			}
		
		}
		public void exibir()
		{
			Console.WriteLine("INFORMAÇÕES DO FUNCIONÁRIO:");
			Int16 i;
			Console.Write("Código de Funcionário: ");
			for(i=0;i<8;i++)
			{
				Console.Write(codigo_func[i]);
			}
			switch(codigo_func[2])
			{
					case 0: Console.WriteLine("\nTURNO: MANHÃ / TARDE");break;
					case 1: Console.WriteLine("\nTURNO: TARDE / NOITE");break;
			}
			Console.WriteLine("SALÁRIO: R$1400,00 + COMISSÃO DE VENDA");
		}
	}
}
