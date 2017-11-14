using System;
using System.Drawing;
using System.Windows.Forms;

namespace G2_Forms
{
  public partial class Inicio : Form
  {
    public Inicio()
    {
      InitializeComponent();
    }
    
    // Os metodos abaixo só servem para abrir os outros forms
    void BtnCadastroClick(object sender, EventArgs e)
    {
      MainForm cadastro=new MainForm();
      cadastro.ShowDialog();
    }
    
    void BtnConsultaClick(object sender, EventArgs e)
    {
      Consulta consulta=new Consulta();
      consulta.ShowDialog();
    }
  }
}
 