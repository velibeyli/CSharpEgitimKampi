using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");
            #region Kategori ekeleme ishlemi
            //Console.Write("Ekelemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UJ12B0H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");

            #endregion

            #region Urun ekleme Ishlemi

            //string productName;
            //decimal productPrice;
            ////bool ProductStatus;

            //Console.Write("Ekelemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Eklediğiniz ürünün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UJ12B0H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi!");

            #endregion

            #region Ürün Listeme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UJ12B0H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            //Console.WriteLine();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UJ12B0H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme Islemi tamamlandi");

            #endregion

            #region Ürün güncelleme işlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UJ12B0H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("productId",productId);
            //command.Parameters.AddWithValue("productName",productName);
            //command.Parameters.AddWithValue("productPrice",productPrice);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme işlemi başarıyla tamamlandı!");

            #endregion

            Console.Read();
        }
    }
}
