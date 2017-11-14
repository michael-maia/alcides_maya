using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace G2_Forms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    
    void Button1Click(object sender, EventArgs e)
    {
      string opcao;
      /* TROCAR O NOME DO PATHFILE ABAIXO PARA UM ARQUIVO EXISTENTE
          PARA FUNCIONAR O PROGRAMA */
      string pathfile=@"C:\\Users\\Roselaine Maia\\Desktop\\dados.txt";
      
      if(rdbAluno.Checked) //Caso o botão c/ a opção do "Aluno" seja selecionado
        opcao="Aluno";
      else //Caso o botão c/ a opção do "Funcionário" seja selecionado
        opcao="Funcionario";
      
      // Abre o arquivo de dados para começar o registro de informações 
      using (StreamWriter writer = new StreamWriter(pathfile,true))
      {
        // Aqui mostra o formato em que vai aparecer no arquivo
        writer.WriteLine("{0} {1} {2} {3}",textCpf.Text,textNome.Text,textSobrenome.Text,opcao);
      }
           
      MessageBox.Show("Dados Enviados!");
    }
    
    void Button2Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
