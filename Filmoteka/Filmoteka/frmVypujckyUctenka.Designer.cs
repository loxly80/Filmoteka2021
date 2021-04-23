
namespace Filmoteka
{
 partial class frmVypujckyUctenka
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
   this.txtUctenka = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // txtUctenka
   // 
   this.txtUctenka.Dock = System.Windows.Forms.DockStyle.Fill;
   this.txtUctenka.Location = new System.Drawing.Point(0, 0);
   this.txtUctenka.Multiline = true;
   this.txtUctenka.Name = "txtUctenka";
   this.txtUctenka.ReadOnly = true;
   this.txtUctenka.Size = new System.Drawing.Size(344, 366);
   this.txtUctenka.TabIndex = 0;
   // 
   // frmVypujckyUctenka
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(344, 366);
   this.Controls.Add(this.txtUctenka);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "frmVypujckyUctenka";
   this.Text = "Účtenka";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox txtUctenka;
 }
}