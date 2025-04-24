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
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");





            //Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");



            //int secilenTablo;
            //Console.WriteLine();
            //Console.WriteLine("1- Ürünler");
            //Console.WriteLine("2- Kategoriler");  
            //Console.WriteLine("3- Siparişler");
            //Console.WriteLine("4- Çıkış Yap");
            //Console.WriteLine("------------------------------");
            //Console.Write("Üzerinde çalışmak istediğiniz tabloyu seçiniz : ");
            //secilenTablo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //string tabloAdi = string.Empty;

            //switch (secilenTablo)
            //{
            //    case 1:
            //        tabloAdi = "TblProduct";
            //        break;
            //    case 2:
            //        tabloAdi = "TblCategory";
            //        break;
            //    case 3:
            //        tabloAdi = "TblOrder";
            //        break;
            //    case 4:
            //        Console.WriteLine("Çıkış yapılıyor...");
            //        return;
            //    default:
            //        Console.WriteLine("Geçersiz bir seçim yaptınız.");
            //        return;

            //}


            //int secilenIslem;

            //Console.WriteLine("1- Listele");
            //Console.WriteLine("2- Ekle");
            //Console.WriteLine("3- Güncelle");
            //Console.WriteLine("4- Sil");
            //Console.WriteLine("5- Çıkış Yap");
            //Console.WriteLine("6- Geri Dön");
            //Console.WriteLine("------------------------------");
            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            //secilenIslem = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            //switch (secilenIslem)
            //{
            //    case 1:
            //        try
            //        {
            //            connection.Open();
            //            string query = $"SELECT * FROM {tabloAdi}";
            //            SqlCommand command = new SqlCommand(query, connection);
            //            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //            DataTable dataTable = new DataTable();
            //            adapter.Fill(dataTable);
            //            foreach (DataRow row in dataTable.Rows)
            //            {
            //                foreach (DataColumn column in dataTable.Columns)
            //                {
            //                    Console.Write(row[column] + "\t");
            //                }
            //                Console.WriteLine();
            //            }

            //        }
            //        catch (Exception ex)
            //        {

            //            Console.WriteLine("Bir hata oluştu : " + ex.Message);
            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //        break;
            //    case 2:
            //        try
            //        {
            //            connection.Open();


            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Bir hata oluştu : " + ex.Message);

            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //        break;
            //}







            
            

            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme



            //Console.Write("Eklemek istediğiniz kategori adı : ");
            //string kategoriAdi = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@categoryName)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@categoryName", kategoriAdi);
            //int result = sqlCommand.ExecuteNonQuery();
            //if (result > 0)
            //{
            //    Console.WriteLine("Kategori başarıyla eklendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Kategori eklenirken bir hata oluştu.");
            //}
            //sqlConnection.Close();


            //Console.WriteLine("---------------------------------------");

            #endregion

            #region Ürün Ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek istediğiniz ürün fiyatı : ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //Console.Write("Ürün durumu (true/false) : ");
            //productStatus = Convert.ToBoolean(Console.ReadLine());
            //sqlCommand.Parameters.AddWithValue("@productStatus", productStatus);
            //int result = sqlCommand.ExecuteNonQuery();
            //if (result > 0)
            //{
            //    Console.WriteLine("Ürün başarıyla eklendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Ürün eklenirken bir hata oluştu.");
            //}
            //sqlConnection.Close();
            //Console.WriteLine("---------------------------------------");


            #endregion

            #region Ürün Listeleme

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TblProduct", sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //Console.WriteLine("Ürün Listesi");
            //Console.WriteLine("---------------------------------------");

            //// Sütun başlıklarını hizalı bir şekilde yazdırıyoruz
            //Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "Ürün ID", "Ürün Adı", "Ürün Fiyatı", "Ürün Durumu");
            //Console.WriteLine("---------------------------------------\n");

            //while (sqlDataReader.Read())
            //{
            //    // Verileri hizalı bir şekilde yazdırıyoruz
            //    Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}",
            //        sqlDataReader["ProductID"],
            //        sqlDataReader["ProductName"],
            //        sqlDataReader["ProductPrice"],
            //        sqlDataReader["ProductStatus"]);

            //}

            //sqlDataReader.Close();
            //sqlConnection.Close();
            //Console.WriteLine("---------------------------------------");

            #endregion

            #region Ürün silme

            //void listProduct()
            //{
            //    SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //    sqlConnection1.Open();
            //    SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM TblProduct", sqlConnection1);
            //    SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            //    Console.WriteLine("Ürün Listesi");
            //    Console.WriteLine("---------------------------------------");

            //    // Sütun başlıklarını hizalı bir şekilde yazdırıyoruz
            //    Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "Ürün ID", "Ürün Adı", "Ürün Fiyatı", "Ürün Durumu");
            //    Console.WriteLine("---------------------------------------\n");

            //    while (sqlDataReader.Read())
            //    {
            //        // Verileri hizalı bir şekilde yazdırıyoruz
            //        Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}",
            //            sqlDataReader["ProductID"],
            //            sqlDataReader["ProductName"],
            //            sqlDataReader["ProductPrice"],
            //            sqlDataReader["ProductStatus"]);

            //    }

            //    sqlDataReader.Close();
            //    sqlConnection1.Close();
            //    Console.WriteLine("---------------------------------------");
            //}
            //listProduct();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM TblProduct WHERE ProductID = @productId", sqlConnection);
            //Console.Write("Silmek istediğiniz ürün ID'si : ");
            //int productId = Convert.ToInt32(Console.ReadLine());
            //sqlCommand.Parameters.AddWithValue("@productId", productId);
            //int result = sqlCommand.ExecuteNonQuery();
            //if (result > 0)
            //{
            //    Console.WriteLine("Ürün başarıyla silindi.");
            //}
            //else
            //{
            //    Console.WriteLine("Ürün silinirken bir hata oluştu.");
            //}
            //sqlConnection.Close();
            //Console.WriteLine("---------------------------------------");


            #endregion



            #region Ürün Güncelleme

            //void listProduct()
            //{
            //    SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //    sqlConnection1.Open();
            //    SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM TblProduct", sqlConnection1);
            //    SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            //    Console.WriteLine("Ürün Listesi");
            //    Console.WriteLine("---------------------------------------");

            //    // Sütun başlıklarını hizalı bir şekilde yazdırıyoruz
            //    Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "Ürün ID", "Ürün Adı", "Ürün Fiyatı", "Ürün Durumu");
            //    Console.WriteLine("---------------------------------------\n");

            //    while (sqlDataReader.Read())
            //    {
            //        // Verileri hizalı bir şekilde yazdırıyoruz
            //        Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}",
            //            sqlDataReader["ProductID"],
            //            sqlDataReader["ProductName"],
            //            sqlDataReader["ProductPrice"],
            //            sqlDataReader["ProductStatus"]);

            //    }

            //    sqlDataReader.Close();
            //    sqlConnection1.Close();
            //    Console.WriteLine("---------------------------------------");
            //}
            //listProduct();

            //Console.Write("Güncellemek istediğiniz ürün ID'si : ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellemek istediğiniz ürün Adı : ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellemek istediğiniz ürün Fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice, ProductStatus = @productStatus WHERE ProductID = @productId", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productId", productId);
            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //Console.Write("Ürün durumu (true/false) : ");
            //bool productStatus = Convert.ToBoolean(Console.ReadLine());
            //sqlCommand.Parameters.AddWithValue("@productStatus", productStatus);
            //int result = sqlCommand.ExecuteNonQuery();
            //if (result > 0)
            //{
            //    Console.WriteLine("Ürün başarıyla güncellendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Ürün güncellenirken bir hata oluştu.");
            //}
            //sqlConnection.Close();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Güncelleme işlemi tamamlandı.");


            #endregion


























            Console.Read();
        }
    }
}
