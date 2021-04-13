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
  private SqlRepo sqlRepo;

  public frmVypujcky(Customer customer)
  {
   InitializeComponent();
   sqlRepo = new SqlRepo("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla-filmoteka;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
   this.customer = customer;
   lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
   RefreshData();
  }

  private void btnVybratFilm_Click(object sender, EventArgs e)
  {
   frmFilm frmFilm = new frmFilm();
   frmFilm.IsDialog = true;
   frmFilm.ShowDialog();
   if (frmFilm.SelectedFilm != null)
   {
    frmVypujckyDialog frmVypujckyDialog = new frmVypujckyDialog(frmFilm.SelectedFilm);
    if (frmVypujckyDialog.ShowDialog() == DialogResult.OK)
    {
     int cena = Convert.ToInt32((frmFilm.SelectedFilm.Price / 24f) * frmVypujckyDialog.Delka);
     if (customer.Credit - cena >= 0)
     {
      sqlRepo.CreateLease(customer, frmFilm.SelectedFilm, frmVypujckyDialog.Delka);
      customer.Credit -= cena;
      sqlRepo.SaveCustomer(customer);
      RefreshData();
      frmVypujckyUctenka frmVypujckyUctenka = new frmVypujckyUctenka(customer, frmFilm.SelectedFilm, frmVypujckyDialog.Delka);
      frmVypujckyUctenka.ShowDialog();
     }
     else
     {
      MessageBox.Show("Nedostatečný kredit");
     }     
    }
   }
  }

  private void RefreshData()
  {
   listView1.Items.Clear();
   listView1.Items.AddRange(sqlRepo.GetLeases(customer).ToArray()); 
  }
 }
}
