﻿
namespace Filmoteka
{
 partial class frmCustomerDialog
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
   this.label1 = new System.Windows.Forms.Label();
   this.txtPrijmeni = new System.Windows.Forms.TextBox();
   this.txtJmeno = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtEmail = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.btnOk = new System.Windows.Forms.Button();
   this.btnCancel = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(10, 15);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(63, 20);
   this.label1.TabIndex = 0;
   this.label1.Text = "Příjmení";
   // 
   // txtPrijmeni
   // 
   this.txtPrijmeni.Location = new System.Drawing.Point(79, 12);
   this.txtPrijmeni.MaxLength = 250;
   this.txtPrijmeni.Name = "txtPrijmeni";
   this.txtPrijmeni.Size = new System.Drawing.Size(155, 27);
   this.txtPrijmeni.TabIndex = 1;
   // 
   // txtJmeno
   // 
   this.txtJmeno.Location = new System.Drawing.Point(79, 45);
   this.txtJmeno.Name = "txtJmeno";
   this.txtJmeno.Size = new System.Drawing.Size(155, 27);
   this.txtJmeno.TabIndex = 3;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(10, 48);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(52, 20);
   this.label2.TabIndex = 2;
   this.label2.Text = "Jméno";
   // 
   // txtEmail
   // 
   this.txtEmail.Location = new System.Drawing.Point(79, 78);
   this.txtEmail.Name = "txtEmail";
   this.txtEmail.Size = new System.Drawing.Size(155, 27);
   this.txtEmail.TabIndex = 5;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(10, 81);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(46, 20);
   this.label3.TabIndex = 4;
   this.label3.Text = "Email";
   // 
   // btnOk
   // 
   this.btnOk.Location = new System.Drawing.Point(12, 121);
   this.btnOk.Name = "btnOk";
   this.btnOk.Size = new System.Drawing.Size(108, 30);
   this.btnOk.TabIndex = 6;
   this.btnOk.Text = "OK";
   this.btnOk.UseVisualStyleBackColor = true;
   this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
   // 
   // btnCancel
   // 
   this.btnCancel.Location = new System.Drawing.Point(126, 121);
   this.btnCancel.Name = "btnCancel";
   this.btnCancel.Size = new System.Drawing.Size(108, 30);
   this.btnCancel.TabIndex = 7;
   this.btnCancel.Text = "Storno";
   this.btnCancel.UseVisualStyleBackColor = true;
   this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
   // 
   // frmCustomerDialog
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(251, 167);
   this.Controls.Add(this.btnCancel);
   this.Controls.Add(this.btnOk);
   this.Controls.Add(this.txtEmail);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.txtJmeno);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.txtPrijmeni);
   this.Controls.Add(this.label1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "frmCustomerDialog";
   this.Text = "frmCustomerDialog";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtPrijmeni;
  private System.Windows.Forms.TextBox txtJmeno;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtEmail;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Button btnOk;
  private System.Windows.Forms.Button btnCancel;
 }
}