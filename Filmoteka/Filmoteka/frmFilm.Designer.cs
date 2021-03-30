
namespace Filmoteka
{
 partial class frmFilm
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
   this.menuZanr = new System.Windows.Forms.ToolStripComboBox();
   this.lvFilmy = new System.Windows.Forms.ListView();
   this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
   this.menuStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuZanr});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(800, 32);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // menuZanr
   // 
   this.menuZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.menuZanr.Name = "menuZanr";
   this.menuZanr.Size = new System.Drawing.Size(121, 28);
   this.menuZanr.SelectedIndexChanged += new System.EventHandler(this.menuZanr_SelectedIndexChanged);
   // 
   // lvFilmy
   // 
   this.lvFilmy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
   this.lvFilmy.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvFilmy.FullRowSelect = true;
   this.lvFilmy.GridLines = true;
   this.lvFilmy.HideSelection = false;
   this.lvFilmy.Location = new System.Drawing.Point(0, 32);
   this.lvFilmy.MultiSelect = false;
   this.lvFilmy.Name = "lvFilmy";
   this.lvFilmy.Size = new System.Drawing.Size(800, 418);
   this.lvFilmy.TabIndex = 1;
   this.lvFilmy.UseCompatibleStateImageBehavior = false;
   this.lvFilmy.View = System.Windows.Forms.View.Details;
   this.lvFilmy.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvFilmy_ColumnClick);
   this.lvFilmy.DoubleClick += new System.EventHandler(this.lvFilmy_DoubleClick);
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "Id";
   this.columnHeader1.Width = 50;
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "Název";
   this.columnHeader2.Width = 150;
   // 
   // columnHeader3
   // 
   this.columnHeader3.Text = "Žánr";
   this.columnHeader3.Width = 150;
   // 
   // columnHeader4
   // 
   this.columnHeader4.Text = "Délka";
   this.columnHeader4.Width = 80;
   // 
   // columnHeader5
   // 
   this.columnHeader5.Text = "Cena (24h)";
   this.columnHeader5.Width = 150;
   // 
   // frmFilm
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.lvFilmy);
   this.Controls.Add(this.menuStrip1);
   this.MainMenuStrip = this.menuStrip1;
   this.Name = "frmFilm";
   this.Text = "Filmy";
   this.Load += new System.EventHandler(this.frmFilm_Load);
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripComboBox menuZanr;
  private System.Windows.Forms.ListView lvFilmy;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.ColumnHeader columnHeader4;
  private System.Windows.Forms.ColumnHeader columnHeader5;
 }
}