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

            //Crud --> Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=TTT\\SQLEXPRESS;initial catalog=CSharpKampDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TBL_Category (CategoryName) Values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.Write("Kategori başarıyla eklendi! ");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=TTT\\SQLEXPRESS;initial catalog=CSharpKampDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TBL_Product (ProductName,ProductPrice,ProductStatus) Values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün Eklemesi Başarılı!");


            #endregion

            #region Ürün Listeleme İşlemi


            //SqlConnection connection = new SqlConnection("Data Source=TTT\\SQLEXPRESS;initial Catalog=CSharpKampDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand ("Select * From TBL_Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // SQL'den verileri çekmek için köprü görevi görür.
            //DataTable dataTable = new DataTable(); // SQL'de ki tablonun hafızada tutulmasını sağlar.
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //     foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " " );
            //    }
            ////    Console.WriteLine("");
            ////}


            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productID=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=TTT\\SQLEXPRESS;initial Catalog=CSharpKampDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TBL_Product Where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Silme İşlemi Başarılı! ");

            //connection.Close();


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productID=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=TTT\\SQLEXPRESS;initial Catalog=CSharpKampDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TBL_Product Set ProductName=@productName,ProductPrice=@productPrice Where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Güncelleme Başarılı! ");

            //connection.Close();

            #endregion
           

            Console.Read();



        }
    }
}
