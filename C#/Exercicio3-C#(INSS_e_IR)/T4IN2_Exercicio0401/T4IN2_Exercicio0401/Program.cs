using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4IN2_Exercício0303
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] salarioBruto = new float[5];
            float[] salarioLiq = new float[5];
            float[] salarioINSS = new float[5];
            float[] descontoINSS = new float[5];
            float[] deducaoIR = new float[5];
            float[] valorIR = new float[5];
            float[] taxaINSS = new float[5];
            float[] taxaIR = new float[5];
            string[] nome = new string[5];
            int i;

            Console.WriteLine("Escreva seu nome e salário:");

            for (i = 0; i < 5; i++)
            {
                bool chave = false;

                Console.Write("> ");
                string[] input = Console.ReadLine().Split(';');
                nome[i] = input[0].ToUpper();
                salarioBruto[i] = float.Parse(input[1]);
                salarioBruto[i] = Math.Abs(salarioBruto[i]);
                //PROCESSANDO DADOS PARA O INSS
                if (salarioBruto[i] <= 1659.38F)
                    taxaINSS[i] = 0.08F;
                else if (salarioBruto[i] <= 2765.66F)
                    taxaINSS[i] = 0.09F;
                else if (salarioBruto[i] <= 5531.31F)
                    taxaINSS[i] = 0.11F;
                else
                {
                    descontoINSS[i] = 608.44F;
                    taxaINSS[i] = 0.11F;
                    chave = true;
                }

                if (chave == false)
                    descontoINSS[i] = salarioBruto[i] * taxaINSS[i];

                salarioINSS[i] = salarioBruto[i] - descontoINSS[i];

                //PROCESSANDO DADOS PARA O IR
                if (salarioLiq[i] <= 1903.98F)
                {
                    taxaIR[i] = 0;
                    deducaoIR[i] = 0;
                }
                else if (salarioLiq[i] <= 2826.65F)
                {
                    taxaIR[i] = 0.075F;
                    deducaoIR[i] = 142.8F;
                }
                else if (salarioLiq[i] <= 3751.05F)
                {
                    taxaIR[i] = 0.15F;
                    deducaoIR[i] = 354.80F;
                }
                else if (salarioLiq[i] <= 4664.68F)
                {
                    taxaIR[i] = 0.225F;
                    deducaoIR[i] = 636.13F;
                }
                else
                {
                    taxaIR[i] = 0.275F;
                    deducaoIR[i] = 869.36F;
                }

                valorIR[i] = (salarioINSS[i] * taxaIR[i]) - deducaoIR[i];

                salarioLiq[i] = salarioBruto[i] - descontoINSS[i] - valorIR[i];
            }

            Console.Clear();
            Console.WriteLine("RESULTADOS INDIVIDUAIS:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Salário Bruto: R$" + Math.Round(salarioBruto[i],2));
                Console.WriteLine("Taxa INSS: {0}%\tValor INSS: R${1}", taxaINSS[i], Math.Round(descontoINSS[i],2));
                Console.WriteLine("Salário IR: R$" + Math.Round(salarioINSS[i]),2);
                Console.WriteLine("Taxa IR: {0}%\tValor de dedução: R${1}", taxaIR[i], Math.Round(deducaoIR[i],2));
                Console.WriteLine("Valor IR: R$" + Math.Round(valorIR[i],2));
                Console.WriteLine("Salário Líquido: R$" + Math.Round(salarioLiq[i]),2);
                Console.WriteLine("--------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
