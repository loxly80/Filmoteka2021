using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public class Film
 {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Genre { get; set; }
  public int Length { get; set; }
  public int Price { get; set; }

  public Film(string name, string genre, int length, int price)
  {
   Name = name;
   Genre = genre;
   Length = length;
   Price = price;
  }

  public Film(int id, string name, string genre, int length, int price)
  {
   Id = id;
   Name = name;
   Genre = genre;
   Length = length;
   Price = price;
  }

  public ListViewItem ToListViewItem()
  {
   return new ListViewItem(new string[] { Id.ToString(), Name, Genre, Length.ToString(), Price.ToString() });
  }  
 }
}
