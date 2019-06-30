using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        // GLOBAL Değişken.
        public static Random rastgele = new Random();
        static void Main(string[] args)
        {
            //SORU1: Klavyeden girilen 5 sayıyı diziye atayacağız.
            // Daha sonra dizi ortalaması bulup döndüren bir metot tanımlayacağız.
            // Tanımladığımız diziyi parametre olarak alacak bu metot dizinin ortalamasını bize döndürecek ve ekrana yazdıracağız.
            // CEVAP1
            //int[] sayilar = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"{i+1}. sayıyı giriniz: ");
            //    string girilenMetin = Console.ReadLine();
            //    sayilar[i] = Convert.ToInt32(girilenMetin);
            //}
            //float ortalama = DiziOrtalama(sayilar);
            //Console.WriteLine($"Dizinin ortalaması: {ortalama}");

            //SORU2: 10 elemanlı bir diziye 100 ile 500 arası rastgele çift sayı atayan programı yazınız.

            int[] dizi = new int[10];
            //Random rastgele = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int sayi = rastgele.Next(100, 501);
            //    if (sayi%2==0)
            //    {
            //        dizi[i] = sayi;
            //        Console.WriteLine(sayi);
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //CiftDiziOlustur(dizi);

            // SORU3: Kalvyeden girilen harfe göre tek veya çift sayı üreten ve bunları diziye atan metodu yazınız. Sayı aralığı 1 - 1000
            // Dizi 5 elemanlı olacak.
            /*
             * Klavyeden C Ç c ç harflerinden birisi girilmişse çift sayı üretecek.
             * Klavyeden T t harflerinden birisi girilmişse tek sayı üretecek.
             * Giriş bunlardan birisi değilse Kullanıcıya uyarı verdirip yenden isteyeceğiz.
             */
            bool girisBasarili = false;
            bool ciftMi=false;

            do
            {
                Console.Write("Tek için T Çift için Ç yazı Enter tuşuna basınız: ");
                string harf = Console.ReadLine();
                if (harf == "C" || harf == "c" || harf == "Ç" || harf == "ç")
                {
                    ciftMi = true;
                    girisBasarili = true;
                }else if(harf == "T" || harf == "t")
                {
                    ciftMi = false;
                    girisBasarili = true;
                }
                else
                {
                    girisBasarili = false;
                }

            } while (girisBasarili == false);

            int[] dizi2 = new int[5];

            // 1. Yöntem
            //if (ciftMi) //ciftMi==true
            //{
            //    Random rast = new Random();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        int randomSayi = rast.Next(1, 1001);
            //        if (randomSayi%2==0)
            //        {
            //            dizi2[i] = randomSayi;
            //            Console.WriteLine(randomSayi);
            //        }
            //        else
            //        {
            //            i--;
            //        }

            //    }
            //}
            //else
            //{
            //    Random rast = new Random();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        int randomSayi = rast.Next(1, 1001);
            //        if (randomSayi % 2 == 1)
            //        {
            //            dizi2[i] = randomSayi;
            //            Console.WriteLine(randomSayi);
            //        }
            //        else
            //        {
            //            i--;
            //        }

            //    }
            //}
            // 2. Yöntem Metotlu
            if (ciftMi==true)
            {
                for (int i = 0; i < 5; i++)
                {
                    dizi2[i] = CiftSayiUret(1, 1000);
                    Console.WriteLine(dizi2[i]);
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    dizi2[i] = TekSayiUret(1, 1000);
                    Console.WriteLine(dizi2[i]);
                }
            }


            

            Console.Read();

        }
        // CEVAP1
        static float DiziOrtalama(int[] sayilar)
        {
            float toplam = 0;
            float ortalama;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            ortalama = toplam / sayilar.Length;
            return ortalama;
        }

        // CEVAP2 Metotlu Yöntem

        static void CiftDiziOlustur(int[] dizi)
        {
            int i = 0;
            while (i < dizi.Length)
            {
                int sayi = rastgele.Next(100, 501);
                if (sayi % 2 == 0)
                {
                    dizi[i] = sayi;
                    Console.WriteLine(sayi);
                    i++;
                }
                else
                {
                    Console.WriteLine("Tek Sayı üretildi: " + sayi);
                }
            }
        }

        // CEVAP3: Metotlu Yöntem
        static int CiftSayiUret(int bas, int son)
        {
            int randomSayi;
            do
            {
                randomSayi = rastgele.Next(bas, son + 1);
                
            } while (randomSayi % 2 == 1);
            return randomSayi;  
        }
        static int TekSayiUret(int bas, int son)
        {
            Random rast = new Random();
            int randomSayi;
            do
            {
                randomSayi = rastgele.Next(bas, son + 1);

            } while (randomSayi % 2 == 0);
            return randomSayi;
        }
    }
}
