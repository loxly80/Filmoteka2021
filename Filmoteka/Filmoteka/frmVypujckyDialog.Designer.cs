
namespace Filmoteka
{
 partial class frmVypujckyDialog
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.lblFilm = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.numDelka = new System.Windows.Forms.NumericUpDown();
   this.label2 = new System.Windows.Forms.Label();
   this.btnOk = new System.Windows.Forms.Button();
   this.btnStorno = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.numDelka)).BeginInit();
   this.SuspendLayout();
   // 
   // lblFilm
   // 
   this.lblFilm.AutoSize = true;
   this.lblFilm.Location = new System.Drawing.Point(12, 9);
   this.lblFilm.Name = "lblFilm";
   this.lblFilm.Size = new System.Drawing.Size(50, 20);
   this.lblFilm.TabIndex = 0;
   this.lblFilm.Text = "label1";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 46);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(105, 20);
   this.label1.TabIndex = 1;
   this.label1.Text = "délka výpůjčky";
   // 
   // numDelka
   // 
   this.numDelka.Location = new System.Drawing.Point(123, 44);
   this.numDelka.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
   this.numDelka.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
   this.numDelka.Name = "numDelka";
   this.numDelka.Size = new System.Drawing.Size(101, 27);
   this.numDelka.TabIndex = 2;
   this.numDelka.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(230, 46);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(17, 20);
   this.label2.TabIndex = 3;
   this.label2.Text = "h";
   // 
   // btnOk
   // 
   this.btnOk.Location = new System.Drawing.Point(12, 86);
   this.btnOk.Name = "btnOk";
   this.btnOk.Size = new System.Drawing.Size(114, 37);
   this.btnOk.TabIndex = 4;
   this.btnOk.Text = "OK";
   this.btnOk.UseVisualStyleBackColor = true;
   this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
   // 
   // btnStorno
   // 
   this.btnStorno.Location = new System.Drawing.Point(132, 86);
   this.btnStorno.Name = "btnStorno";
   this.btnStorno.Size = new System.Drawing.Size(114, 37);
   this.btnStorno.TabIndex = 5;
   this.btnStorno.Text = "Storno";
   this.btnStorno.UseVisualStyleBackColor = true;
   this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
   // 
   // frmVypujckyDialog
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(258, 135);
   this.Controls.Add(this.btnStorno);
   this.Controls.Add(this.btnOk);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.numDelka);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.lblFilm);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "frmVypujckyDialog";
   this.Text = "Délka výpůjčky";
   ((System.ComponentModel.ISupportInitialize)(this.numDelka)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lblFilm;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.NumericUpDown numDelka;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnOk;
  private System.Windows.Forms.Button btnStorno;
 }
}