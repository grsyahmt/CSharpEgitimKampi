using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice =13.67;
            //orangePrice =11.65;
            //strawberryPrice = 15.82;
            //potatoPrice = 8.52;
            //tomatoPrice = 6.87;

            //Console.WriteLine("---Elma Birim Fiyatı:" + applePrice+ " TL");
            //Console.WriteLine("---Portakal Birim Fiyatı:" + orangePrice+" TL");
            //Console.WriteLine("---Çilek Birim Fiyatı:" + strawberryPrice+" TL");
            //Console.WriteLine("---Patates Birim Fiyatı:" + potatoPrice+" TL");
            //Console.WriteLine("---Domates Birim Fiyatı:" + tomatoPrice+" TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.232;
            //orangeGram = 1.299;
            //strawberryGram = 0.740;
            //potatoGram = 4.120;
            //tomatoGram = 3.689;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün:Elma - Birim Fiyatı:"+applePrice+" - Gramaj:"+appleGram+" - Toplam Tutar:"+appleTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Portalak - Birim Fiyatı:" + potatoPrice + " - Gramaj:" + orangeGram +" - Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Çilek - Birim Fiyatı:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Patates - Birim Fiyatı:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Domates - Birim Fiyatı:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı:"+shoppingTotalPrice+ " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Gidilecek İlçe / İl: "+passengerDistrict+ " / "+passengerCity);
            //Console.WriteLine("Yolcu Yaşı: "+passengerAge);
            //Console.WriteLine("Yolcunun Kimlik Bilgisi: "+passengerIdentityNumber);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int computerPrice, tvPrice, shoesPrice, chairPrice;

            //int computerCount, tvCount, shoesCount, chairCount;

            //computerPrice = 14000;
            //tvPrice = 30000;
            //shoesPrice = 4500;
            //chairPrice = 8000;

            //Console.Write("Lütfen satın aldığınız bilgisayar adetini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen satın aldığınız televizyon adetini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen satın aldığınız ayakkabı adetini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen satın aldığınız sandalye adetini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //int totaLShoppingPrice= computerCount*computerPrice + tvCount*tvPrice + shoesCount*shoesPrice+chairCount*chairPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + totaLShoppingPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("İlk Sınav Notunuzu Giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/ 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            #endregion

            Console.Read();
        }
    }
}
