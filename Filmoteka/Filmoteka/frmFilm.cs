using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmFilm : Form
 {
  public Film SelectedFilm { get; set; }
  public bool IsDialog { get; set; }

  private List<Film> films;
  private SqlRepo sqlRepo;
  private int sortColumn;
  private bool desc;
  

  public frmFilm()
  {
   InitializeComponent();
   
   sqlRepo = new SqlRepo("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla-filmoteka;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
   //sqlRepo.CreateFilms();
  }

  private void frmFilm_Load(object sender, EventArgs e)
  {
   DataRefresh(sortColumn,desc);
  }

  private void DataRefresh(int column, bool desc)
  {
   films = sqlRepo.GetFilms(column, desc);
   lvFilmy.Items.Clear();
   menuZanr.Items.Clear();
   menuZanr.Items.Add("Všechny");
   foreach (var film in films)
   {
    if (!menuZanr.Items.Contains(film.Genre)) menuZanr.Items.Add(film.Genre);
    lvFilmy.Items.Add(film.ToListViewItem());
   }
  }

  private void DataRefresh(string genre, int column, bool desc)
  {
   films = sqlRepo.GetFilms(genre, column, desc);
   lvFilmy.Items.Clear();
   foreach (var film in films)
   {
    lvFilmy.Items.Add(film.ToListViewItem());
   }
  }

  private void menuZanr_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (menuZanr.SelectedIndex <= 0)
    DataRefresh(sortColumn,desc);
   else
    DataRefresh(menuZanr.Items[menuZanr.SelectedIndex].ToString(), sortColumn, desc);
  }

  private void lvFilmy_ColumnClick(object sender, ColumnClickEventArgs e)
  {
   if (sortColumn == e.Column) desc = !desc;
   sortColumn = e.Column;
   if (menuZanr.SelectedIndex <= 0)
    DataRefresh(sortColumn, desc);
   else
    DataRefresh(menuZanr.Items[menuZanr.SelectedIndex].ToString(), sortColumn, desc);
  }

  private void lvFilmy_DoubleClick(object sender, EventArgs e)
  {
   if (IsDialog)
   {
    if (lvFilmy.SelectedIndices.Count > 0)
    {
     SelectedFilm = films[lvFilmy.SelectedIndices[0]];
     Close();
    }
   }   
  }
 }
}
