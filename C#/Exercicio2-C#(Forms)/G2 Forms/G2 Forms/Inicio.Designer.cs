/*
 * Created by SharpDevelop.
 * User: Roselaine Maia
 * Date: 01/12/2016
 * Time: 12:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace G2_Forms
{
  partial class Inicio
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnCadastro = new System.Windows.Forms.Button();
      this.btnConsulta = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(40, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(128, 23);
      this.label3.TabIndex = 4;
      this.label3.Text = "Bem-Vindo";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(40, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(128, 23);
      this.label4.TabIndex = 5;
      this.label4.Text = "O que deseja fazer:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCadastro
      // 
      this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCadastro.Location = new System.Drawing.Point(56, 104);
      this.btnCadastro.Name = "btnCadastro";
      this.btnCadastro.Size = new System.Drawing.Size(96, 32);
      this.btnCadastro.TabIndex = 6;
      this.btnCadastro.Text = "Cadastro";
      this.btnCadastro.UseVisualStyleBackColor = true;
      this.btnCadastro.Click += new System.EventHandler(this.BtnCadastroClick);
      // 
      // btnConsulta
      // 
      this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.btnConsulta.Location = new System.Drawing.Point(56, 176);
      this.btnConsulta.Name = "btnConsulta";
      this.btnConsulta.Size = new System.Drawing.Size(96, 32);
      this.btnConsulta.TabIndex = 7;
      this.btnConsulta.Text = "Consulta";
      this.btnConsulta.UseVisualStyleBackColor = true;
      this.btnConsulta.Click += new System.EventHandler(this.BtnConsultaClick);
      // 
      // Inicio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(202, 261);
      this.Controls.Add(this.btnConsulta);
      this.Controls.Add(this.btnCadastro);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Name = "Inicio";
      this.Text = "Inicio";
      this.ResumeLayout(false);
    }
    private System.Windows.Forms.Button btnConsulta;
    private System.Windows.Forms.Button btnCadastro;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}
