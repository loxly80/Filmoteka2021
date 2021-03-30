
namespace Filmoteka
{
 partial class frmVypujcky
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
   this.lblCustomerName = new System.Windows.Forms.Label();
   this.listView1 = new System.Windows.Forms.ListView();
   this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
   this.btnVybratFilm = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lblCustomerName
   // 
   this.lblCustomerName.AutoSize = true;
   this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
   this.lblCustomerName.Location = new System.Drawing.Point(12, 9);
   this.lblCustomerName.Name = "lblCustomerName";
   this.lblCustomerName.Size = new System.Drawing.Size(96, 38);
   this.lblCustomerName.TabIndex = 0;
   this.lblCustomerName.Text = "label1";
   // 
   // listView1
   // 
   this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
   this.listView1.GridLines = true;
   this.listView1.HideSelection = false;
   this.listView1.Location = new System.Drawing.Point(38, 134);
   this.listView1.MultiSelect = false;
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(647, 522);
   this.listView1.TabIndex = 3;
   this.listView1.UseCompatibleStateImageBehavior = false;
   this.listView1.View = System.Windows.Forms.View.Details;
   // 
   // columnHeader6
   // 
   this.columnHeader6.Text = "Id";
   this.columnHeader6.Width = 50;
   // 
   // columnHeader7
   // 
   this.columnHeader7.Text = "Název";
   this.columnHeader7.Width = 150;
   // 
   // columnHeader8
   // 
   this.columnHeader8.Text = "Čas aktivace";
   this.columnHeader8.Width = 150;
   // 
   // columnHeader9
   // 
   this.columnHeader9.Text = "Délka aktivace";
   this.columnHeader9.Width = 80;
   // 
   // btnVybratFilm
   // 
   this.btnVybratFilm.Location = new System.Drawing.Point(24, 64);
   this.btnVybratFilm.Name = "btnVybratFilm";
   this.btnVybratFilm.Size = new System.Drawing.Size(125, 40);
   this.btnVybratFilm.TabIndex = 4;
   this.btnVybratFilm.Text = "Vybrat film";
   this.btnVybratFilm.UseVisualStyleBackColor = true;
   this.btnVybratFilm.Click += new System.EventHandler(this.btnVybratFilm_Click);
   // 
   // frmVypujcky
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(742, 678);
   this.Controls.Add(this.btnVybratFilm);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.lblCustomerName);
   this.Name = "frmVypujcky";
   this.Text = "frmVypujcky";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lblCustomerName;
  private System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.ColumnHeader columnHeader6;
  private System.Windows.Forms.ColumnHeader columnHeader7;
  private System.Windows.Forms.ColumnHeader columnHeader8;
  private System.Windows.Forms.ColumnHeader columnHeader9;
  private System.Windows.Forms.Button btnVybratFilm;
 }
}