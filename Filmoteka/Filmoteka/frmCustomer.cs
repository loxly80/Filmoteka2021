using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmCustomer : Form
 {
  private List<Customer> customers;
  private SqlRepo sqlRepo;

  public frmCustomer()
  {
   InitializeComponent();
   sqlRepo = new SqlRepo("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla-filmoteka;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
  }

  private void frmCustomer_Load(object sender, EventArgs e)
  {
   DataRefresh();
  }

  private void DataRefresh()
  {
   customers = sqlRepo.GetCustomers();
   lvCustomer.Items.Clear();
   foreach (var customer in customers)
   {
    lvCustomer.Items.Add(customer.ToListViewItem());
   }
  }

  private void tsPridat_Click(object sender, EventArgs e)
  {
   Customer customer = new Customer("", "", "", 500);
   frmCustomerDialog frmCustomerDialog = new frmCustomerDialog(customer);
   if (frmCustomerDialog.ShowDialog() == DialogResult.OK)
   {
    sqlRepo.SaveCustomer(customer);
    DataRefresh();
   }
  }

  private void tsUpravit_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    frmCustomerDialog frmCustomerDialog = new frmCustomerDialog(customers[lvCustomer.SelectedIndices[0]]);
    if (frmCustomerDialog.ShowDialog() == DialogResult.OK)
    {
     sqlRepo.SaveCustomer(customers[lvCustomer.SelectedIndices[0]]);
     DataRefresh();
    }
   }
  }

  private void tsSmazat_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    try
    {
     sqlRepo.Delete(customers[lvCustomer.SelectedIndices[0]]);
    }
    catch
    {
     MessageBox.Show("Na zákazníka existují vazby - nelze ho smazat");
    }
   }
  }

  private void ts500_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    sqlRepo.AddCredit(customers[lvCustomer.SelectedIndices[0]], 500);
    DataRefresh();
   }
  }

  private void ts1000_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    sqlRepo.AddCredit(customers[lvCustomer.SelectedIndices[0]], 1000);
    DataRefresh();
   }
  }

  private void ts2000_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    sqlRepo.AddCredit(customers[lvCustomer.SelectedIndices[0]], 2000);
    DataRefresh();
   }
  }

  private void tsVypujcky_Click(object sender, EventArgs e)
  {
   if (lvCustomer.SelectedIndices.Count > 0)
   {
    frmVypujcky frmVypujcky = new frmVypujcky(customers[lvCustomer.SelectedIndices[0]]);
    frmVypujcky.ShowDialog();
   }
  }
 }
}
