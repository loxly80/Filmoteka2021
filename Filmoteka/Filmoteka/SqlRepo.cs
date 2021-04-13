using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Filmoteka
{
 public class SqlRepo
 {
  private string[] filmColumns = new string[] { "IdFilm", "Name", "Genre", "Length", "Price" };

  public string ConnectionString { get; set; }

  public SqlRepo(string connectionString)
  {
   ConnectionString = connectionString;
  }

  public void CreateFilms()
  {
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand("", connection))
    {
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film01','detektivka',100,50) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film02','detektivka',100,50) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film03','sci-fi',150,40) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film04','detektivka',100,60) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film05','sci-fi',130,50) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film06','detektivka',100,40) ";
     command.CommandText += $"insert into Film(Name,Genre,Length,Price) values('film07','fantasy',200,100) ";
     connection.Open();
     command.ExecuteNonQuery();
     connection.Close();
    }
   }
  }

  public List<Film> GetFilms(int columnOrder, bool descending)
  {
   List<Film> result = new List<Film>();
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select * from Film", connection))
    {
     if (columnOrder >= 0 && columnOrder < filmColumns.Length)
     {
      command.CommandText += $" order by {filmColumns[columnOrder]} {(descending ? "desc" : "")}";
     }
     connection.Open();
     using (SqlDataReader dataReader = command.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new Film(Convert.ToInt32(dataReader["IdFilm"])
                          , dataReader["Name"].ToString()
                          , dataReader["Genre"].ToString()
                          , Convert.ToInt32(dataReader["Length"])
                          , Convert.ToInt32(dataReader["Price"])));
      }
     }
     connection.Close();
    }
   }
   return result;
  }

  public List<Film> GetFilms(string genre, int columnOrder, bool descending)
  {
   List<Film> result = new List<Film>();
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select * from Film where genre='{genre}'", connection))
    {
     if (columnOrder >= 0 && columnOrder < filmColumns.Length)
     {
      command.CommandText += $" order by {filmColumns[columnOrder]} {(descending ? "desc" : "")}";
     }
     connection.Open();
     using (SqlDataReader dataReader = command.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new Film(Convert.ToInt32(dataReader["IdFilm"])
                          , dataReader["Name"].ToString()
                          , dataReader["Genre"].ToString()
                          , Convert.ToInt32(dataReader["Length"])
                          , Convert.ToInt32(dataReader["Price"])));
      }
     }
     connection.Close();
    }
   }
   return result;
  }

  public List<Customer> GetCustomers()
  {
   List<Customer> result = new List<Customer>();
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select * from Customer", connection))
    {
     connection.Open();
     using (SqlDataReader dataReader = command.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new Customer(Convert.ToInt32(dataReader["IdCustomer"])
                          , dataReader["LastName"].ToString()
                          , dataReader["FirstName"].ToString()
                          , dataReader["Email"].ToString()
                          , Convert.ToInt32(dataReader["Credit"])));
      }
     }
     connection.Close();
    }
   }
   return result;
  }

  public void SaveCustomer(Customer customer)
  {
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"", connection))
    {
     connection.Open();
     if (customer.Id == 0)
     {
      command.CommandText = $"insert into Customer(LastName,FirstName,Email,Credit) output inserted.IdCustomer values(@LastName,@FirstName,@Email,500)";
     }
     else
     {
      command.CommandText = $"update Customer set LastName=@LastName, FirstName=@FirstName, Email=@Email, Credit={customer.Credit} ";
     }
     command.Parameters.AddWithValue("LastName", customer.LastName);
     command.Parameters.AddWithValue("FirstName", customer.FirstName);
     command.Parameters.AddWithValue("Email", customer.Email);

     if (customer.Id == 0)
      customer.Id = Convert.ToInt32(command.ExecuteScalar());
     else
      command.ExecuteNonQuery();

     connection.Close();
    }
   }
  }

  public void Delete(Customer customer)
  {
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"", connection))
    {
     connection.Open();
     command.CommandText = $"delete from Customer where IdCustomer={customer.Id}";
     command.ExecuteNonQuery();
     connection.Close();
    }
   }
  }

  public void AddCredit(Customer customer, int credit)
  {
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"", connection))
    {
     connection.Open();
     command.CommandText = $"update Customer set Credit = Credit + {credit} where IdCustomer={customer.Id}";
     command.ExecuteNonQuery();
     connection.Close();
    }
   }
  }

  public void CreateLease(Customer customer, Film film, int length)
  {
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"", connection))
    {
     connection.Open();
     command.CommandText = $"insert into Lease(IdCustomer,IdFilm,StartTime,ActivationLength) values({customer.Id},{film.Id},getdate(),{length})";
     command.ExecuteNonQuery();
     connection.Close();
    }
   }
  }

  public List<ListViewItem> GetLeases(Customer customer)
  {
   List<ListViewItem> result = new List<ListViewItem>();
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select Film.Name, Lease.StartTime, Lease.ActivationLength from Lease join Film on Lease.IdFilm=Film.IdFilm where Lease.IdCustomer={customer.Id} and DATEADD(hour,Lease.ActivationLength,Lease.StartTime)>getdate()", connection))
    {
     connection.Open();
     using (SqlDataReader dataReader = command.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new ListViewItem(new string[] {
          dataReader["Name"].ToString()
        , Convert.ToDateTime(dataReader["StartTime"]).ToString("dd.MM.yyyy - HH:mm")
        , dataReader["ActivationLength"].ToString()}));
      }
     }
     connection.Close();
    }
   }
   return result;
  }

  public double AverageLeaseLength()
  {
   double result = 0;
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select AVG(ActivationLength) from Lease", connection))
    {
     connection.Open();
     result = Convert.ToDouble(command.ExecuteScalar());
     connection.Close();
    }
   }
   return result;
  }

  public string Top3Films()
  {
   List<string> result = new List<string>();
   using (SqlConnection connection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand command = new SqlCommand($"select top 3 Lease.IdFilm,Film.Name, Pocet=COUNT(*) from Lease join Film on Lease.IdFilm=Film.IdFilm group by Lease.IdFilm, Film.Name order by Pocet desc", connection))
    {
     connection.Open();
     using (SqlDataReader dataReader = command.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(dataReader["Name"].ToString());
      }
     }
     connection.Close();
    }
   }
   return string.Join(", ", result);
  }
 }

}
