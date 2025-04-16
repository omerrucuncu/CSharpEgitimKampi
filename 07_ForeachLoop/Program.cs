using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            //string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 8, 1124, 125421, 32553, 4352, 332 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //List<string> cities = new List<string> { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}




            #endregion

            #region Örnek sınav sistemi uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını al

            Console.WriteLine("-----------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
             
            // Öğrenci isimlerini ve notlarını tutmak için diziler oluştur

            string[] studentNames = new string[studentCount];
            double[] studentScores = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalScore = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.notunu giriniz : ");
                    

                    double score = double.Parse(Console.ReadLine());
                    totalScore += score; // we add the score to the total score
                    Console.WriteLine();
                }

                studentScores[i] = totalScore / 3; // we calculate the average score
            }

            // Öğrenci ortalaması ve geçip kalma durumunu kontrol et



            Console.Read();


            #endregion
        }
    }
}
