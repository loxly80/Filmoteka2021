
namespace Filmoteka
{
 partial class Form1
 {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.btnFilmy = new System.Windows.Forms.Button();
   this.btnZakaznici = new System.Windows.Forms.Button();
   this.btnVypujcky = new System.Windows.Forms.Button();
   this.btnStatistiky = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // btnFilmy
   // 
   this.btnFilmy.Location = new System.Drawing.Point(12, 12);
   this.btnFilmy.Name = "btnFilmy";
   this.btnFilmy.Size = new System.Drawing.Size(243, 29);
   this.btnFilmy.TabIndex = 0;
   this.btnFilmy.Text = "Filmy";
   this.btnFilmy.UseVisualStyleBackColor = true;
   this.btnFilmy.Click += new System.EventHandler(this.btnFilmy_Click);
   // 
   // btnZakaznici
   // 
   this.btnZakaznici.Location = new System.Drawing.Point(12, 47);
   this.btnZakaznici.Name = "btnZakaznici";
   this.btnZakaznici.Size = new System.Drawing.Size(243, 29);
   this.btnZakaznici.TabIndex = 1;
   this.btnZakaznici.Text = "Zákazníci";
   this.btnZakaznici.UseVisualStyleBackColor = true;
   this.btnZakaznici.Click += new System.EventHandler(this.btnZakaznici_Click);
   // 
   // btnVypujcky
   // 
   this.btnVypujcky.Enabled = false;
   this.btnVypujcky.Location = new System.Drawing.Point(12, 82);
   this.btnVypujcky.Name = "btnVypujcky";
   this.btnVypujcky.Size = new System.Drawing.Size(243, 29);
   this.btnVypujcky.TabIndex = 2;
   this.btnVypujcky.Text = "Výpůjčky";
   this.btnVypujcky.UseVisualStyleBackColor = true;
   // 
   // btnStatistiky
   // 
   this.btnStatistiky.Location = new System.Drawing.Point(12, 117);
   this.btnStatistiky.Name = "btnStatistiky";
   this.btnStatistiky.Size = new System.Drawing.Size(243, 29);
   this.btnStatistiky.TabIndex = 3;
   this.btnStatistiky.Text = "Statistiky";
   this.btnStatistiky.UseVisualStyleBackColor = true;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(267, 162);
   this.Controls.Add(this.btnStatistiky);
   this.Controls.Add(this.btnVypujcky);
   this.Controls.Add(this.btnZakaznici);
   this.Controls.Add(this.btnFilmy);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "Form1";
   this.Text = "Filmotéka";
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnFilmy;
  private System.Windows.Forms.Button btnZakaznici;
  private System.Windows.Forms.Button btnVypujcky;
  private System.Windows.Forms.Button btnStatistiky;
 }
}

