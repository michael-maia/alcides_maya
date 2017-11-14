/*
 * Created by SharpDevelop.
 * User: Roselaine Maia
 * Date: 27/11/2016
 * Time: 17:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace G2_Forms
{
  partial class MainForm
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
      this.textNome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textSobrenome = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textCpf = new System.Windows.Forms.MaskedTextBox();
      this.rdbAluno = new System.Windows.Forms.RadioButton();
      this.rdbFunc = new System.Windows.Forms.RadioButton();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(16, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // textNome
      // 
      this.textNome.AcceptsTab = true;
      this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.textNome.Location = new System.Drawing.Point(112, 48);
      this.textNome.Name = "textNome";
      this.textNome.Size = new System.Drawing.Size(128, 23);
      this.textNome.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(16, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 23);
      this.label2.TabIndex = 0;
      this.label2.Text = "Sobrenome:";
      // 
      // textSobrenome
      // 
      this.textSobrenome.AcceptsTab = true;
      this.textSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.textSobrenome.Location = new System.Drawing.Point(112, 88);
      this.textSobrenome.Name = "textSobrenome";
      this.textSobrenome.Size = new System.Drawing.Size(128, 23);
      this.textSobrenome.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(184, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 23);
      this.label3.TabIndex = 4;
      this.label3.Text = "Cadastro";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(16, 128);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 23);
      this.label4.TabIndex = 5;
      this.label4.Text = "CPF:";
      // 
      // textCpf
      // 
      this.textCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.textCpf.Location = new System.Drawing.Point(112, 128);
      this.textCpf.Mask = "000.000.000-00";
      this.textCpf.Name = "textCpf";
      this.textCpf.Size = new System.Drawing.Size(128, 23);
      this.textCpf.TabIndex = 3;
      this.textCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // rdbAluno
      // 
      this.rdbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.rdbAluno.Location = new System.Drawing.Point(296, 48);
      this.rdbAluno.Name = "rdbAluno";
      this.rdbAluno.Size = new System.Drawing.Size(120, 24);
      this.rdbAluno.TabIndex = 4;
      this.rdbAluno.TabStop = true;
      this.rdbAluno.Text = "Aluno";
      this.rdbAluno.UseVisualStyleBackColor = true;
      // 
      // rdbFunc
      // 
      this.rdbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.rdbFunc.Location = new System.Drawing.Point(296, 88);
      this.rdbFunc.Name = "rdbFunc";
      this.rdbFunc.Size = new System.Drawing.Size(120, 24);
      this.rdbFunc.TabIndex = 5;
      this.rdbFunc.TabStop = true;
      this.rdbFunc.Text = "Funcionário";
      this.rdbFunc.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.button1.Location = new System.Drawing.Point(104, 192);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(120, 32);
      this.button1.TabIndex = 6;
      this.button1.Text = "Enviar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.button2.Location = new System.Drawing.Point(264, 192);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(120, 32);
      this.button2.TabIndex = 7;
      this.button2.Text = "Voltar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 258);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.rdbFunc);
      this.Controls.Add(this.rdbAluno);
      this.Controls.Add(this.textCpf);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textSobrenome);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textNome);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.Text = "G2 Forms";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RadioButton rdbFunc;
    private System.Windows.Forms.RadioButton rdbAluno;
    private System.Windows.Forms.MaskedTextBox textCpf;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textSobrenome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textNome;
    private System.Windows.Forms.Label label1;
    
    
  }
}
