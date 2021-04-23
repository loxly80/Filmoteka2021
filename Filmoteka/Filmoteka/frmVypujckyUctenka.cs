using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public partial class frmVypujckyUctenka : Form
 {
  public frmVypujckyUctenka(Customer customer, Film film, int delka)
  {
   InitializeComponent();
   txtUctenka.Text = " Půjčovna filmů Jirka \r\n";
   txtUctenka.Text += $"Zákazník: {customer.FirstName} {customer.LastName} \r\n";
   txtUctenka.Text += $"Film: {film.Name}  \r\n";
   txtUctenka.Text += $"Čas aktivace: {DateTime.Now.ToString("dd.MM.yyyy - hh:mm")}  \r\n";
   txtUctenka.Text += $"Čas čas deaktivace: {DateTime.Now.AddHours(delka).ToString("dd.MM.yyyy - hh:mm")}  \r\n";
   float cena = (film.Price / 24f) * delka;
   txtUctenka.Text += $"Cena: {cena.ToString("C")}  \r\n";
   txtUctenka.Text += $"Zbývající kredit: {(customer.Credit).ToString("C")}  \r\n";
    // nesedí výpočet nevím proč ...
  }
 }
}
