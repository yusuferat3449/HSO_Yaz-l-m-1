using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_2
{
    class Program
    {
        // 6 Parametre almayan ve string değer döndüren metot.
        static string ASCII_Dondur()
        {
            Console.Write("Tek bir tuşa basınız.");
            int karakter = Console.Read(); // ASCII değeri int olarak alınır
            string donus = $"Klavyedek girilen karakterin ASCII değeri: {karakter} ";
            return donus;
        }
        static void Main(string[] args)
        {
            ////1
            //piKare();

            ////2
            //carpmaYap(44, 99);

            ////3
            //// string merhaba = "Merhaba Dünyalılar";
            //string merhaba = merhabaDondur();
            //Console.WriteLine(merhaba);

            ////4
            //double pi2 = piKareDondur();
            //Console.WriteLine(pi2);

            //// 4 2. Kullanım Yöntemi
            //Console.WriteLine(piKareDondur());

            //// 5
            //int dortgenCevre = dortgenCevreDondur(23, 55);
            //Console.WriteLine("Dörtgenin Çevresi: " + dortgenCevre);

            //// 5 2. string interpolasyon
            //Console.WriteLine($"Dörtgenin Çevresi: {dortgenCevreDondur(23, 55)}");

            //// 6
            //string cevap = ASCII_Dondur();
            //Console.WriteLine(cevap);

            ////7
            //icice();

            ////8
            //int[] dizi1 = new int[] {77,66,88,33,22,90 };
            //DiziYazdir(dizi1);

            //// 9
            //int[] donenDizi = DiziDondur(5);
            //for (int i = 0; i < donenDizi.Length; i++)
            //{
            //    Console.WriteLine($"{i} . eleman {i}");
            //}

            //10
            //sayilariCarp(3);
            //sayilariCarp(3,5);
            //sayilariCarp(3,5,8);
            //sayilariCarp(3,5,8,55);

            // 11

            ogrenciNumaralari("405 Yazılım Uzmanlığı Eğitimi", 45, 34, 55, 77, 99);
            ogrenciNumaralari("404 Yazılım Uzmanlığı Eğitimi", 55, 77, 99);


            Console.ReadKey();
        }
        // 1. Parametre almayan ve değer döndürmeyen metot
        static void piKare()
        {
            double sonuc = Math.PI * Math.PI;
            Console.WriteLine("Pi sayısının karesi: " + sonuc);
        }

        // 2. Parametre alan ve değer döndürmeyen metot
        static void carpmaYap(int s1, int s2)
        {
            int sonuc = s1 * s2;
            Console.WriteLine("Çarpma İşleminin Sonucu: " + sonuc);
        }

        // 3. Parametre almayan ve string değer döndüren metot
        static string merhabaDondur()
        {
            string merhaba = "Merhaba Dünyalılar";
            return merhaba;
        }
        // 4. Parametre almayan ve double değer döndüren metot.
        static double piKareDondur()
        {
            double sonuc = Math.PI * Math.PI;
            return sonuc;
        }

        // 5. Parametre alan ve int değer döndüren metot
        static int dortgenCevreDondur(int kenar1, int kenar2)
        {
            int sonuc = 2 * (kenar1 + kenar2);
            return sonuc;

        }

        // 7. İçİçe Metot Kullanımı

        static void icice()
        {
            Console.WriteLine("Merhaba SmartPro'lular");
            Console.WriteLine(merhabaDondur());
        }

        // 8. Parametre olarak dizi göndermek.
        static void DiziYazdir(int[] dizi1)
        {
            foreach (var eleman in dizi1)
            {
                Console.WriteLine(eleman);
            }
        }

        // 9. Dizi döndüren metotlar
        static int[] DiziDondur(int sayi) {
            // 0 den kendisine parametre olarak gönderilen sayıya kadar(sayı dahil) olan elemanları dizi olarak döndüren metot.
            int[] dizi = new int[sayi+1];
            for (int i = 0; i <= sayi; i++)
            {
                dizi[i] = i;
            }
            return dizi;
        }

        // 10. params anahtar kelimesi (değişken sayıda parametre)
        static void sayilariCarp(params int[] sayilar)
        {
            // Kendisine gönderilen sayıların çarpımını ekrana yazdıran metot.
            // Sayıların adeti değişebilir.
            double sonuc=1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc = sonuc * sayilar[i];
            }
            Console.WriteLine($"Gönderilen sayıların çarpımı: {sonuc}");
        }

        // 11 Farklı parametrelerin params ile bir arada kullanımı.
        // params hep en sağda olmak zorundadır.
        // 1 tane params kullanılabilir.
        static void ogrenciNumaralari(string sinifadi, params int[] numaralar)
        {
            Console.WriteLine($"Sınıf Adı: {sinifadi}");
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"{i+1}. Öğrencinin Numarası: {numaralar[i]}");
            }
        }

    }
}

/*
 * Metot Overloading anlatılacak.
 * Ref Out Anlatılacak.
 * Parametrelerde detaylara girilecek.(params)
 */
