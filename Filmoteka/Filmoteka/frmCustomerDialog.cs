using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmCustomerDialog : Form
 {
  private Customer customer;

  public frmCustomerDialog(Customer customer)
  {
   InitializeComponent();
   this.customer = customer;
   txtPrijmeni.Text = customer.LastName;
   txtJmeno.Text = customer.FirstName;
   txtEmail.Text = customer.Email;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
   if (txtJmeno.Text.Trim() == "") 
    MessageBox.Show("Musíte zadat jméno!!!");
   else if (txtPrijmeni.Text.Trim() == "")
    MessageBox.Show("Musíte zadat příjmení!!!");
   else if (txtEmail.Text.Trim() == "")
    MessageBox.Show("Musíte zadat email!!!");
   else
   {
    customer.FirstName = txtJmeno.Text;
    customer.LastName = txtPrijmeni.Text;
    customer.Email = txtEmail.Text;
    DialogResult = DialogResult.OK;
    Close();
   }   
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
   DialogResult = DialogResult.Cancel;
   Close();
  }
 }
}
