
namespace Filmoteka
{
 partial class frmCustomer
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
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.lvCustomer = new System.Windows.Forms.ListView();
   this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(800, 24);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // lvCustomer
   // 
   this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
   this.lvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvCustomer.GridLines = true;
   this.lvCustomer.HideSelection = false;
   this.lvCustomer.Location = new System.Drawing.Point(0, 24);
   this.lvCustomer.MultiSelect = false;
   this.lvCustomer.Name = "lvCustomer";
   this.lvCustomer.Size = new System.Drawing.Size(800, 426);
   this.lvCustomer.TabIndex = 2;
   this.lvCustomer.UseCompatibleStateImageBehavior = false;
   this.lvCustomer.View = System.Windows.Forms.View.Details;
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "Id";
   this.columnHeader1.Width = 50;
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "Příjmení";
   this.columnHeader2.Width = 150;
   // 
   // columnHeader3
   // 
   this.columnHeader3.Text = "Jméno";
   this.columnHeader3.Width = 150;
   // 
   // columnHeader4
   // 
   this.columnHeader4.Text = "Email";
   this.columnHeader4.Width = 80;
   // 
   // columnHeader5
   // 
   this.columnHeader5.Text = "Kredit";
   this.columnHeader5.Width = 150;
   // 
   // frmCustomer
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.lvCustomer);
   this.Controls.Add(this.menuStrip1);
   this.MainMenuStrip = this.menuStrip1;
   this.Name = "frmCustomer";
   this.Text = "Zákazníci";
   this.Load += new System.EventHandler(this.frmCustomer_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ListView lvCustomer;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.ColumnHeader columnHeader4;
  private System.Windows.Forms.ColumnHeader columnHeader5;
 }
}