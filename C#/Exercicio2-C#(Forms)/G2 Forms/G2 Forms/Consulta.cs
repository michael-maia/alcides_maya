/* ORDEM DAS INFORMAÇÕES NO ARQUIVO DE DADOS:
   CPF / NOME / SOBRENOME / OPÇÃO(ALUNO OU FUNCIONÁRIO) */
   
/* OBS: NÃO SERÁ NECESSÁRIO SE PREOCUPAR COM MAIS DE UM REGISTRO COM MESMO CPF POIS
   EM TEORIA O PRIMEIRO DEVERÁ SER O CORRETO E SOMENTE ELE VAI SER PRINTADO */
   
/* OBS2: DESCOBRIR COMO FAZER O CPF PARAR DE MOSTRAR "," AO INVÉS DE "." */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace G2_Forms
{
  public partial class Consulta : Form
  {
    public Consulta()
    {
      InitializeComponent();
    }
    
    void BtnBuscarClick(object sender, EventArgs e)
    {
       /* TROCAR O NOME DO PATHFILE ABAIXO PARA UM ARQUIVO EXISTENTE
          PARA FUNCIONAR O PROGRAMA */
       string pathfile=@"C:\\Users\\Roselaine Maia\\Desktop\\dados.txt";
       string cpf;
       int chave=0,cont=0;;
       string[] array = new string[4];
       
       cpf=textConsulta.Text; //Informação do textbox da Consulta
       
       if(File.Exists(pathfile)) //Testa a existência do arquivo com os dados
       {
         try
         {
           /* Abre o arquivo de dados para começar a leitura */
           using(StreamReader reader = new StreamReader(pathfile,true))
           {
             /* Vai criar um vetor que irá gravar o conteudo do arquivo, porém a cada
                espaço encontrado ele vai pular de posição do vetor */
             string[] vetor = reader.ReadLine().Split(' ');
             //Começa a ser varrido o vetor para procurar o CPF informado pelo user
             foreach (string s in vetor)
             {
               if(s==cpf) //Se for encontrado ativará uma chave
                chave++;
               if(chave==1)
               {
                 /* Após ter encontrado a linha onde está o CPF da consulta ele vai capturar 
                    as próximas 4 informações do vetor para um array diferente, pois são os 4
                    dados do cadastro */
                 if(cont!=4) 
                 {                
                   array[cont]=s;
                   cont++;
                 }
               }
                
             }
           }
         }
         catch(Exception error){
           Console.WriteLine("Ocorreu um erro: '{0}'",error);}
       }
       else
         Console.WriteLine("O arquivo "+pathfile+" não foi encontrado!");
         
       if(chave==1) //Mostra as informações caso encontre o CPF informado pelo user
       {
         MessageBox.Show("INFORMAÇÕES\n\n"+array[3]+"\nNome: "+array[1]+"\nSobrenome: "+array[2]+"\nCPF: "+array[0]);
       }
       else
         MessageBox.Show("Não foi encontrado nenhuma informação correspondente");
    }
    
    void BtnVoltarClick(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
