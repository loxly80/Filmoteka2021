using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmVypujckyDialog : Form
 {
  private Film film;
  public int Delka { get; set; }

  public frmVypujckyDialog(Film film)
  {
   InitializeComponent();
   this.film = film;
   lblFilm.Text = film.Name;
   DialogResult = DialogResult.Cancel;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
   DialogResult = DialogResult.OK;
   Delka = Convert.ToInt32(numDelka.Value);
   Close();
  }

  private void btnStorno_Click(object sender, EventArgs e)
  {
   Close();
  }
 }
}
