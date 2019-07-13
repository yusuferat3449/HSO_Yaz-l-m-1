using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // SORU1: 
            //    3 int parametre alan ve üçgen çevre hesabını 
            //    yapan metodu değer döndüren ve döndürmeyen 
            //    2 şekliyle yazınız.
            // */
            ////CEVAP1:
            //UcgenCevreYaz(3, 4, 5);
            //UcgenCevreYaz(6, 8, 10);

            //int ucgenCevre = UcgenCevreDondur(3, 4, 5);
            //Console.WriteLine($"Üçgenin Çevresi: {ucgenCevre} cm'dir.");

            /*
            // SORU2: int bir değer alan metot 1'den aldığı 
            //    değere kadar olan sayıları toplayıp döndürecek.
            // */
            ////CEVAP2:
            //int toplam = SayiTopla(5);
            //Console.WriteLine($"1'den 5'e kadar olan sayıların toplamı: {toplam}");

            /*
            // SORU3: Parametre olarak aldığı 2 int değerin
            //    birbirinin katı olup olmadğını ekrana yazdıran
            //    metot.
            */

            ////CEVAP3:
            ////KatiMi(15, 5);
            ////KatiMi(5, 15);
            ////KatiMi(5, 5);

            //KatiMiKisa(15, 5);
            //KatiMiKisa(5, 15);
            //KatiMiKisa(5, 3);





            /*SORU4: Dizi eleman sayısı istiyoruz. Sonra bu değere kadar klavyeden sayı isteyip diziye atıyoruz.
             * Main içerisinde bir sayı istenecek ve bu sayıya kadar döngü oluşturup 
             * girilen elemanlar diziye atanacak.
             * Daha sonra bu dizi diziCarpma isimli metota gönderilecek.
             * Bu metot dizinin elemanlarını çarpıp ekrana yazdıracak.
             */

            //CEVAP4:

            //Console.Write("Kaç eleman gireceksiniz?");
            //string okunan = Console.ReadLine();
            //int elemanSayisi = Convert.ToInt32(okunan);

            //int[] elemanlar = new int[elemanSayisi];

            //for (int i = 0; i < elemanSayisi; i++)
            //{
            //    Console.Write($"{i+1}. sayıyı giriniz: ");
            //    string sayiStr = Console.ReadLine();
            //    int sayi = Convert.ToInt32(sayiStr);

            //    elemanlar[i] = sayi;
            //}

            //diziCarpma(elemanlar);


            // SORU5:

            /*
             * Kendisine gönderilen sayıları toplayıp sonucu döndüren metotu yazınız.
             */

            //CEVAP5

            //int toplam = sayilariTopla(4, 5, 7, 88);
            //Console.WriteLine("Toplam = " + toplam);

            // SORU6: 
            /* toplamGoster isimli 3 farklı metot
             * tanımlıyoruz.
             * Bu metotlardan 1. si kendisine gönderilen int tipinde
             * sayıların toplamını gösterecek(adet farketmeksizin)
             * 
             * Bu metotlardan 2. si kendisine gönderilen float tipinde
             * sayıların toplamını gösterecek(adet farketmeksizin)
             * 
             * Bu metotlardan 3. sü kendisine gönderilen decimal tipinde
             * sayıların toplamını gösterecek(adet farketmeksizin)
             */

            //// CEVAP6:
            //toplamGoster(1, 2, 3);
            //toplamGoster(15, 44, 5.5F, 77.9f);
            //toplamGoster(1000.45m, 100000, 25, 13.99m);



            







            Console.ReadKey();
}

































//CEVAP1:
static void UcgenCevreYaz(int k1, int k2, int k3)
{
int cevre = k1 + k2 + k3;
Console.WriteLine($"Üçgenin Çevresi: {cevre} cm'dir.");
}
static int UcgenCevreDondur(int k1, int k2, int k3)
{
int cevre = k1 + k2 + k3;
return cevre;
}
//CEVAP2:
static int SayiTopla(int sayi)
{
int toplam = 0;
for (int i = 1; i <=sayi ; i++)
{
    toplam = toplam + i;
}
return toplam;
}
//CEVAP3:
static void KatiMi(int sayi1, int sayi2)
{
if(sayi1>sayi2)
{
    int kalan = sayi1 % sayi2;
    if (kalan==0)
    {
        Console.WriteLine($"{sayi1} sayısı {sayi2} sayısının katıdır.");
    }
    else
    {
        Console.WriteLine($"{sayi1} sayısı {sayi2} sayısının katı değildir.");
    }
}else if(sayi1<sayi2)
{
    int kalan = sayi2 % sayi1;
    if (kalan==0)
    {
        Console.WriteLine($"{sayi2} sayısı {sayi1} sayısının katıdır.");
    }
    else
    {
        Console.WriteLine($"{sayi2} sayısı {sayi1} sayısının katı değildir.");
    }
}
else
{
    Console.WriteLine("Sayılar eşittir.");
}
}
    // CEVAP3 Kısa Yöntem
    static void KatiMiKisa(int sayi1, int sayi2)
    {
    int buyuk = Math.Max(sayi1, sayi2);
    int kucuk = Math.Min(sayi1, sayi2);
    int kalan = buyuk % kucuk;
    if (buyuk==kucuk)
    {
        Console.WriteLine("Sayılar Eşit");
    }
    else
    {
        if (kalan == 0)
        {
            Console.WriteLine($"{buyuk} ve {kucuk} Birbirlerinin katıdır.");
        }
        else
        {
            Console.WriteLine($"{buyuk} ve {kucuk} Birbirlerinin katı değildir.");
        }
    }

    }

        // CEVAP4
        static void diziCarpma(int[] elemanlar)
        {
            double sonuc = 1;
            for (int i = 0; i < elemanlar.Length; i++)
            {
                sonuc = sonuc * elemanlar[i];
            }
            Console.WriteLine("Dizi elemanlarının çarpımı :" + sonuc);
        }


        //CEVAP5:

        static int sayilariTopla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            return toplam;
        }


        // CEVAP6: 1. seçenek.
        static void toplamGoster(params int[] sayilar)
        {
            var toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
        // CEVAP6: 2. seçenek.
        static void toplamGoster(params float[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
        // CEVAP6: 3. seçenek.
        static void toplamGoster(params decimal[] sayilar)
        {
            decimal toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}
