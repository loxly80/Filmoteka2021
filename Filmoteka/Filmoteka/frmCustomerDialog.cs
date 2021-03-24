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
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
   
  }
 }
}
