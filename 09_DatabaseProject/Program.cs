using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Siparişler");
            Console.WriteLine("3-Ürünler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------");

            string tableName = string.Empty;

            // Kullanıcı girişine göre tablo belirleme
            switch (tableNumber)
            {
                case "1":
                    tableName = "TblCategory";
                    break;
                case "2":
                    tableName = "TblOrder";
                    break;
                case "3":
                    tableName = "TblProduct";
                    break;
                case "4":
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    return;
            }

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NBMSEF4\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            try
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Verileri konsola yazdırma
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Console.Write($"{column.ColumnName}: {row[column]}  ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Console.Read();
        }
    }
}
