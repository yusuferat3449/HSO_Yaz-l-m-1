﻿using System;
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

            //ogrenciNumaralari("405 Yazılım Uzmanlığı Eğitimi", 45, 34, 55, 77, 99);
            //ogrenciNumaralari("404 Yazılım Uzmanlığı Eğitimi", 55, 77, 99);

            //// 12
            //Aciklama();

            //// 13

            //ogrBilgiYazdir(1992, "Servi", 55);
            //ogrBilgiYazdir(1992);

            //// 14 isimler ile parametrelere değer atamak
            //namedParametre(soyad: "Demir", yas: 77, ad: "Mehmet");


            //15 Metoetların AŞırı Yüklenmesi.

            //metot();
            //metot(5);
            //metot("SmartPro");
            //metot(3, 5);

            //16
            // ref 'te ilk değer ataması zorunludur. out'da ilk değer atanmasa da program çalışır.

            //int s = 99;
            int s;
            //sayiGoster(s);
            //Console.WriteLine("Sayının main içerisindeki değeri: "+s);

            //sayiGoster(ref s);
            //Console.WriteLine("Sayının main içerisindeki değeri: " + s);

            sayiGoster(out s);
            Console.WriteLine("Sayının main içerisindeki değeri: " + s);

            // 17
            
            Faktoriyel(5);
            //return 5 * (4 * (3 * (2 * (1) * 1))


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

        //12 Metot açıklaması eklemek.

        ///<summary>
        /// Bu metoda açıklama eklenmiştir.
        /// Açıklama için 3 adet / işareti koymak yeterlidir.
        /// summary etiketleri arasına yazılır.
        ///</summary>
        static void Aciklama() {
            Console.WriteLine("Açıklama Metodu Çalıştı.");
        }


        //13
        // Opsiyonel Parametreli Metotlar
        // Opsiyonel parametrelere değer gönderilmez ise vrasayılan değeri kullanılır.
        static void ogrBilgiYazdir(int dogumYili=0, string ad = "NONAME", int kilo=60)
        {
            Console.WriteLine($"Ad: {ad} Doğum Yılı: {dogumYili} Kilo: {kilo}");
        }


        // 14: İsimli Kullanım, Named Parametreli Metotlar:
        static void namedParametre(string ad, string soyad, int yas)
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas}");

            //strin birleştirme
            string adSoyad = string.Concat(ad, " ", soyad);
            Console.WriteLine(adSoyad);
        }














        // 15: Methotların aşırı yüklenmesi: MethodOverloading
        static void metot()
        {
            Console.WriteLine("404 Sınıf");
        }

        static void metot(int a)
        {
            Console.WriteLine(a);
        }

        static void metot(int a, int b)
        {
            Console.WriteLine(a +" " +b);
        }

        static void metot(string b)
        {
            Console.WriteLine(b);
        }

        // 16 : ref ve out anahtar sözcüğü

        static void sayiGoster(int sayi)
        {
            sayi = 55;
            Console.WriteLine("Metot içindeki sayi: " + sayi);
        }
        //static void sayiGoster(ref int sayi)
        //{
        //    sayi = 55;
        //    Console.WriteLine("Metot içindeki sayi: " + sayi);
        //}
        static void sayiGoster(out int sayi)
        {
            sayi = 55;
            Console.WriteLine("Metot içindeki sayi: " + sayi);
        }


        // 17
        // Kendini çağıran metotlar: Recursive

        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1);
        }

    }
}

/*
 * Metot Overloading anlatılacak.
 * Ref Out Anlatılacak.
 * Parametrelerde detaylara girilecek.(params)
 */





