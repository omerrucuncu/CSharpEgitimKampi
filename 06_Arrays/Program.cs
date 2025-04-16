using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Dizideki en büyük elemanı bulma

            void EnBuyukSayiBulma(){
                int[] sayilar = { 142, 1111, 321421, 213211, 2332, 24, 745674, 5655, 43643, 215 };
                int enBuyukSayi = sayilar[0];
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] > enBuyukSayi)
                    {
                        enBuyukSayi = sayilar[i];
                    }
                }
                Console.WriteLine("Dizideki en büyük sayı: " + enBuyukSayi);

                Console.Read();
            }

            // EnBuyukSayiBulma();

            #endregion

            
            

        }
    }
}
