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

            //()
            // Geriye değer döndürmeyen metotlar
            //customer --> listele,ekle,sil,güncelle
            // Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ahmet Gürsoy");
            //    Console.WriteLine("Kaan Turan");
            //}

            //CustomerList();

            //------------------------------------------------------------------------------------------------
            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            //------------------------------------------------------------------------------------------------

            #endregion
            #region Geriye Değer Döndürmeyen Parametleri Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri:"+name+" "+surName);
            //}
            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion
            #region Geriye Değer Döndürmeyen Int Parametleri Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Sum(3, 5, 6);


            #endregion
            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(studentCard());
            //Console.Read();

            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + CountryName + " - \nBaşkent: " + capital + " - \nBayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.Read();


            #endregion
            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}
            //Console.WriteLine(Sum(54, 67));
            //Console.WriteLine(Sum(82, 217));

            #endregion
            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci başarılı oldu" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız oldu" + " Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ahmet", 42, 52, 74));
            //Console.WriteLine(ExamResult("Merve", 30, 41, 23));

            #endregion

            //Console.Read();
        }
    }
}
