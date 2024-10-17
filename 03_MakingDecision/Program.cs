using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //------------------------------------------------------------------------------------------------------

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //------------------------------------------------------------------------------------------------------

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Turkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler Yanlış");
            //}

            //------------------------------------------------------------------------------------------------------

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //------------------------------------------------------------------------------------------------------

            //int exam1, exam2, exam3, average;
            //string result = " ";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalamanız: " + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average >= 50 & average <= 69)
            //{
            //    result = "Sonuc İdare Eder";
            //}
            //if (average >= 70 & average <= 84)
            //{
            //    result = "Sonuç Güzel";
            //}
            //if (average >= 85 & average <= 100)
            //{
            //    result = "Sonuç Harika";
            //}
            //Console.WriteLine(result);

            //------------------------------------------------------------------------------------------------------

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if(city == "Ankara"| city =="Adana" | city =="İstanbul" | city=="İzmit")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //------------------------------------------------------------------------------------------------------

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            #endregion
            #region Mod İşlemleri
            //------------------------------------------------------------------------------------------------------

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2. sayıya bölümünden kalan "+result);
            //Console.Read();

            //------------------------------------------------------------------------------------------------------

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int num1 = int.Parse(Console.ReadLine());

            //if(num1 %2 ==0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            //Console.Read();
            #endregion
            #region Char Değişkenler ile Karar Yapıları
            //------------------------------------------------------------------------------------------------------

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team =='G'| team =='g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else 
            //{
            //    Console.WriteLine("Böyle bir takım sembolü bulunmamaktadır.");
            //}

            //------------------------------------------------------------------------------------------------------
            #endregion
            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Alanı Seçin: ");
            //menuItem = Console.ReadLine();

            //if(menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Kıymalı Makarna");
            //}
            //if(menuItem =="2")
            //{
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbaı");
            //    Console.WriteLine("2- Tarhana Çorbası");
            //    Console.WriteLine("3- Yoğurt Çorbası");
            //}
            //if (menuItem =="3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Bol Malzemos Pizza");
            //    Console.WriteLine("2- Margarita Pizza");
            //    Console.WriteLine("3- Vegan Pizza");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Diyet Kola");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("4- Ayran");
            //    Console.WriteLine("5_ Gazoz");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Kazandibi");
            //    Console.WriteLine("4- Ekler");
            //}

            //Console.Read();
            #endregion
            #region Switch-Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNum = int.Parse(Console.ReadLine());

            //    switch (monthNum)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;                       
            //    default: Console.Write("Hatalı Veri Girişi"); break;



            //}
            //Console.Read();

            #endregion
            #region Switch-Case Hesap Makinesi

            //int num1, num2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //num1= int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //switch(symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Toplam: " +result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Fark: "+result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Çarpım: "+result);
            //        break;              
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Bölüm: "+result);
            //        break ;
            //}
            //Console.Read();
            #endregion
        }
    }
}
