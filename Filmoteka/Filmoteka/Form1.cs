using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnFilmy_Click(object sender, EventArgs e)
  {
   frmFilm frmFilm = new frmFilm();
   frmFilm.IsDialog = false;
   frmFilm.ShowDialog();
  }

  private void btnZakaznici_Click(object sender, EventArgs e)
  {
   frmCustomer frmCustomer = new frmCustomer();
   frmCustomer.ShowDialog();
  }
 }
}
