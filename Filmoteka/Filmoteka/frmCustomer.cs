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
   sqlRepo = new SqlRepo("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla-filmoteka;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
 }
}
