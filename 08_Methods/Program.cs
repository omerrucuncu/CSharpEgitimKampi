using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // Metotlar, belirli bir işlevi yerine getiren kod bloklarıdır.

            // Metotlar, kodunuzu daha düzenli ve okunabilir hale getirir.

            // Metotlar, kodunuzu tekrar kullanmanıza olanak tanır.

            // Metotlar, kodunuzu daha modüler hale getirir.

            // Metotlar, kodunuzu daha test edilebilir hale getirir.

            // Metotlar, kodunuzu daha bakımı kolay hale getirir.

            //void CustomerList()
            //{
            //    Console.WriteLine("Müşteri Listesi");
            //    Console.WriteLine("1. Ahmet Yılmaz");
            //    Console.WriteLine("2. Ayşe Demir");
            //    Console.WriteLine("3. Mehmet Öz");
            //    Console.WriteLine("4. Fatma Yıldız");
            //    Console.WriteLine("5. Ali Can");
            //}

            //void sum(int a, int b)
            //{
            //    Console.WriteLine("Toplama İşlemi");
            //    Console.WriteLine("Sonuç: " + (a + b));
            //}






            #endregion

            #region  Geriye değer döndürmeyen parametreli metotlar

            void CustomerCard(string name, string surname, int age)
            {
                Console.WriteLine("Müşteri Kartı");
                Console.WriteLine("Ad: " + name);
                Console.WriteLine("Soyad: " + surname);
                Console.WriteLine("Yaş: " + age);
            }



            #endregion

            #region Geriye değer döndüren metotlar

            // Geriye değer döndüren metotlar, belirli bir işlevi yerine getirdikten sonra bir değer döndürür.

            // Geriye değer döndüren metotlar, genellikle bir hesaplama yapar ve sonucu döndürür.

            // Geriye değer döndüren metotlar, genellikle bir veri türü belirtir.

            string CustomerName()
            {
                Console.WriteLine("Müşteri Adı");
                string name = Console.ReadLine();
                return name;
            }

            string StudentCard()
            {
                string name = "Ali";
                string surname = "Can";

                return name + " " + surname;
            }







            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string countryCard = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak Renkleri: " + flagColor;
            //    return countryCard;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkent adını giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak renklerini giriniz : ");
            //z = Console.ReadLine();

            //string a = CountryCard(x, y, z);
            //Console.WriteLine(a);

            #endregion



            Console.Read();
        }
    }
}
