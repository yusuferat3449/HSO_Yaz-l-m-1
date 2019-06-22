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
            //1
            piKare();

            //2
            carpmaYap(44, 99);

            //3
            // string merhaba = "Merhaba Dünyalılar";
            string merhaba = merhabaDondur();
            Console.WriteLine(merhaba);

            //4
            double pi2 = piKareDondur();
            Console.WriteLine(pi2);

            // 4 2. Kullanım Yöntemi
            Console.WriteLine(piKareDondur());

            // 5
            int dortgenCevre = dortgenCevreDondur(23, 55);
            Console.WriteLine("Dörtgenin Çevresi: " + dortgenCevre);

            // 5 2. string interpolasyon
            Console.WriteLine($"Dörtgenin Çevresi: {dortgenCevre}");

            // 6
            string cevap = ASCII_Dondur();
            Console.WriteLine(cevap);

            //7
            icice();

            //8
            int[] dizi1 = new int[] {77,66,88,33,22,90 };
            DiziYazdir(dizi1);

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
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
 * Metot Overloading anlatılacak.
 * Ref Out Anlatılacak.
 * Parametrelerde detaylara girilecek.
 */
