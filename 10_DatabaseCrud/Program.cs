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
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");





            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");



            int secilenTablo;
            Console.WriteLine();
            Console.WriteLine("1- Ürünler");
            Console.WriteLine("2- Kategoriler");  
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("------------------------------");
            Console.Write("Üzerinde çalışmak istediğiniz tabloyu seçiniz : ");
            secilenTablo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string tabloAdi = string.Empty;

            switch (secilenTablo)
            {
                case 1:
                    tabloAdi = "TblProduct";
                    break;
                case 2:
                    tabloAdi = "TblCategory";
                    break;
                case 3:
                    tabloAdi = "TblOrder";
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    return;

            }


            int secilenIslem;

            Console.WriteLine("1- Listele");
            Console.WriteLine("2- Ekle");
            Console.WriteLine("3- Güncelle");
            Console.WriteLine("4- Sil");
            Console.WriteLine("5- Çıkış Yap");
            Console.WriteLine("6- Geri Dön");
            Console.WriteLine("------------------------------");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            secilenIslem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");


            switch (secilenIslem)
            {
                case 1:
                    try
                    {
                        connection.Open();
                        string query = $"SELECT * FROM {tabloAdi}";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                Console.Write(row[column] + "\t");
                            }
                            Console.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Bir hata oluştu : " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    break;
                case 2:
                    try
                    {
                        connection.Open();
                        

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu : " + ex.Message);
                        
                    }
                    finally
                    {
                        connection.Close();
                    }
                    break;
            }













            // Buraya seçilen tabloya göre listeleme işlemi yapılacak


















            Console.Read();
        }
    }
}
