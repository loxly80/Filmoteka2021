using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmVypujcky : Form
 {
  private Customer customer;

  public frmVypujcky(Customer customer)
  {
   InitializeComponent();
   this.customer = customer;
   lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
  }

  private void btnVybratFilm_Click(object sender, EventArgs e)
  {
   frmFilm frmFilm = new frmFilm();
   frmFilm.IsDialog = true;
   frmFilm.ShowDialog();
   if (frmFilm.SelectedFilm != null)
   {
    MessageBox.Show($"Vybral jsem {frmFilm.SelectedFilm.Name}");
   }
  }
 }
}
