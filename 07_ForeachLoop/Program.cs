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
            #region Foreach Döngüsü

            // foreach(1;2;3;4)
            //1.Parametre: Değişken Türü
            //2.Parametre: Değişken Adı
            //3.Parametre: In
            //4.Parametre: Liste,Koleksiyon,Dizi

            //string[] cities = { "Milano", "Budapeşte", "İzmir", "Ankara", "İstanbul" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //---------------------------------------------------------------------------------------------------------------------------

            //int[] numbers = { 23, 41, 535, 342, 756, 852, 12, 213 };
            //{
            //    foreach (int num in numbers)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //---------------------------------------------------------------------------------------------------------------------------

            //int[] numbers = { 23, 41, 535, 342, 756, 852, 12, 213 };
            //{
            //    foreach (int i in numbers)
            //    {
            //        if(i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //---------------------------------------------------------------------------------------------------------------------------

            //int[] numbers = { 23, 41, 535, 342, 756, 852, 12, 213 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //---------------------------------------------------------------------------------------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};

            // foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //---------------------------------------------------------------------------------------------------------------------------

            //string wordl = "Merhaba";
            //foreach (char c in wordl)
            //{
            //    Console.WriteLine(c);
            //}

            //---------------------------------------------------------------------------------------------------------------------------


            #endregion
            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci İsimlerini ve Not Ortalamalarını Saklayacak Diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvarage = new double[studentCount];

            //for (int i= 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    //Her Öğrenci İçin 3 Sınav Notu Girişi

            //    for(int j =0; j<3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value =double.Parse(Console.ReadLine());
            //        totalExamResult += value; // Notları Topluyoruz
            //    }
            //    Console.WriteLine();

            //    studentExamAvarage[i] = totalExamResult / 3;
            //}

            //// Sınav Ortalamaları
            //for( int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvarage[i]}");

            //    // Öğrencilerin Ortalaması ve Geçip Kalma Durumları
            //    if (studentExamAvarage[i] >=50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //}


            #endregion
        }
    }
}
