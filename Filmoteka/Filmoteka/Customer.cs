using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public class Customer
 {
  public Customer(string lastName, string firstName, string email, int kredit)
  {
   LastName = lastName;
   FirstName = firstName;
   Email = email;
   Credit = kredit;
  }

  public Customer(int id, string lastName, string firstName, string email, int kredit)
  {
   Id = id;
   LastName = lastName;
   FirstName = firstName;
   Email = email;
   Credit = kredit;
  }

  public int Id { get; set; }
  public string LastName { get; set; }
  public string FirstName { get; set; }
  public string Email { get; set; }
  public int Credit { get; set; }

  public ListViewItem ToListViewItem()
  {
   return new ListViewItem(new string[] { Id.ToString(), LastName, FirstName, Email, Credit.ToString() });
  }
 }
}
