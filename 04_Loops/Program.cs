using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü              

            void Toplam()
            {
                int a, n, toplam;

                Console.Write("***** Bir sayıdan diğerine kadar olan sayıların toplamı *****");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Hangi sayıdan başlamak istiyorsunuz : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("İkinci sayıyı yazınız : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                toplam = 0;

                for (int i = a; i <= n; i++)
                {
                    toplam += i;
                }

                Console.WriteLine(toplam);

            }




            #endregion

            #region For döngüsü ile karar yapıları

            // Beşe bölünen sayılar Döngü ve karar yapısı kullanımı

            void BeseBolunenSayilar()
            {
                for (int i = 0; i < 101; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }


            }

            void CiftSayilarToplami()
            {
                int toplam = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                    
                }
                Console.WriteLine(toplam);
                Console.Read();
            }







            #endregion

            #region While Döngüsü



            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 sayının basamakları toplamını hesaplayan kodu yazınız

            void BasamaklariTopla()
            {
                

                Console.Write("Sayıyı giriniz : ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine(number);

                int ones, tens, hundreds;
                int sum;

                ones = number % 10;
                tens = (number % 100) / 10;
                hundreds = number / 100;





                
                
            }

            

           

           

            #endregion


            Console.Read();
        }
    }
}
