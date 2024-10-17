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
            #region Temel Dizi Örnekleri
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);
            //--------------------------------------------------------------------------------------------------------------------
            //string[] cities = new string[5];
            //{
            //    cities[0] = "Milano";
            //    cities[1] = "Paris";
            //    cities[2] = "New York";
            //    cities[3] = "Barcelona";
            //    cities[4] = "Madrid";

            //    Console.WriteLine(cities[4]);
            //}
            //--------------------------------------------------------------------------------------------------------------------
            //int[] numbers = new int[10];
            //numbers[0] = 321;
            //numbers[1] = 482;
            //numbers[2] = 94;
            //numbers[3] = 4823;
            //numbers[4] = 999;

            //Console.WriteLine(numbers[5]);
            //--------------------------------------------------------------------------------------------------------------------
            //string[] cities = { "Prag", "İstanbul", "Ankara", "Atina" };

            //Console.WriteLine(cities[2]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Gri", "Beyaz", "Siyah" };

            //for(int i =0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);   
            //}
            //--------------------------------------------------------------------------------------------------------------------
            //int[] numbers = { 1, 3, 9, 15, 242, 325, 645, 4574, 234234 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]% 3 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //--------------------------------------------------------------------------------------------------------------------
            //int[] myArrays = { 1, 2, 3234, 4255, 86, 100, 41 };
            //int maxNum = myArrays[0];

            //for(int i=0; i<myArrays.Length; i++)
            //{
            //    if(myArrays[i] > maxNum)
            //    {
            //        maxNum = myArrays[i];
            //    }
            //}
            //Console.WriteLine(maxNum);
            //--------------------------------------------------------------------------------------------------------------------

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Merve", "Feyza" };
            //Console.WriteLine(persons.Length);

            //--------------------------------------------------------------------------------------------------------------------
            // Sort diziyii küçükten büyüğe sıralar

            //int[] numbers = { 32, 64, 85, 234, 21, 934 };
            //Array.Sort(numbers);
            //for(int i=0;i< numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //--------------------------------------------------------------------------------------------------------------------

            // Reverse diziyi tersten yazar 

            //int[] numbers = { 32, 64, 85, 234, 21, 934 };
            //Array.Reverse(numbers);
            //for(int i = 0; i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //--------------------------------------------------------------------------------------------------------------------
            #endregion
            #region Dizi Metotlar

            //string[] customers= { "Nur", "Çınar", "İlyas", "Betül" };
            //int index = Array.IndexOf(customers, "İlyas");
            //Console.WriteLine(index);

            //--------------------------------------------------------------------------------------------------------------------------

            //int[] num = { 45, 342, 2341, 126, 876, 94543, 234, 2323 };
            //Console.WriteLine("Dizinin en büyük elemanı: "+ num.Max()+" \nDizinin en küçün elemanı: "+ num.Min());

            //--------------------------------------------------------------------------------------------------------------------------


            #endregion
            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------");
            //}
            //Console.WriteLine("Girdiğiniz Şehirler");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //----------------------------------------------------------------------------------------------------------------

            //int[] num = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i =0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //Console.WriteLine(sum);

            //----------------------------------------------------------------------------------------------------------------

            //int[] numbers = { 21,42,54,53,765,94, 87, 91, 2933, 774 };
            //Console.WriteLine("Çift Sayılar");
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine("Tek Sayılar");
            //for(int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
        }
    }
}
