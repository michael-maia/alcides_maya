/* Created by SharpDevelop. */
 
using System;
using System.Windows.Forms;

namespace G2_Forms
{
  internal sealed class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      /* O primeiro form a ser aberto será o Início.cs pois a partir dele 
       * há métodos que servem para abrir os outros forms */
      Application.Run(new Inicio());
    }
    
  }
}
