/*
 * Created by SharpDevelop.
 * User: Roselaine Maia
 * Date: 01/12/2016
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace G2_Forms
{
  partial class Consulta
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.textConsulta = new System.Windows.Forms.MaskedTextBox();
      this.btnVoltar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(64, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Consulta";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(64, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "CPF";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.btnBuscar.Location = new System.Drawing.Point(72, 176);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(91, 32);
      this.btnBuscar.TabIndex = 4;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
      // 
      // textConsulta
      // 
      this.textConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.textConsulta.Location = new System.Drawing.Point(48, 120);
      this.textConsulta.Mask = "000.000.000-00";
      this.textConsulta.Name = "textConsulta";
      this.textConsulta.Size = new System.Drawing.Size(136, 23);
      this.textConsulta.TabIndex = 5;
      this.textConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnVoltar
      // 
      this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.btnVoltar.Location = new System.Drawing.Point(72, 224);
      this.btnVoltar.Name = "btnVoltar";
      this.btnVoltar.Size = new System.Drawing.Size(91, 32);
      this.btnVoltar.TabIndex = 6;
      this.btnVoltar.Text = "Voltar";
      this.btnVoltar.UseVisualStyleBackColor = true;
      this.btnVoltar.Click += new System.EventHandler(this.BtnVoltarClick);
      // 
      // Consulta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(230, 284);
      this.Controls.Add(this.btnVoltar);
      this.Controls.Add(this.textConsulta);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Consulta";
      this.Text = "Consulta";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
    private System.Windows.Forms.Button btnVoltar;
    private System.Windows.Forms.MaskedTextBox textConsulta;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}
