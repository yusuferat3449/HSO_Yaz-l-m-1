using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU1: Dortgen isminde bir sınıf tanımlayın.
            // Bu sınıfın en,boy özellikleri olsun.
            // Bu sınıfın CevreHesapla ve AlanHesapla
            // isimli 2 adet metodu olsun.

            //CEVAP1:
            //Dortgen d1 = new Dortgen();

            //d1.mEn = 5;
            //d1.mBoy = 10;
            //d1.CevreHesapla();
            //Console.WriteLine("Dortgenin Alanı: " + d1.AlanHesapla(6,7));

            //SORU2:Sınıf Televizyon;
            // KDVHesapla(); KDV = Fiyat * 0.18;
            // Yapıcı Metotdunda: "Yeni TV oluşturuldu."
            // Yıkıcı Metotdunda: "Bir TV yok edildi."

            //CEVAP2:
            //Televizyon t1 = new Televizyon("Arçelik","T4500","Siyah",6020.5D,"1920X1080",55.0F);

            //Console.WriteLine(t1.Marka +"->"+ t1.Model);
            //Console.WriteLine("KDV'li Fiyatı: "+t1.KDVliFiyat);


            //SORU3: HesapMakinesi isimli sınıfı tanımla.
            // İki adet sayıyı tutan özelliği ve 4 işlem metodu tanımlayınız(static metotlar).

            //CEVAP3:
            //Console.WriteLine(HesapMakinesi.Topla(55, 45));
            //Console.WriteLine(HesapMakinesi.Cikar(55, 45));
            //Console.WriteLine(HesapMakinesi.Carp(55, 45));
            //Console.WriteLine(HesapMakinesi.Bol(55, 45));

            //HesapMakinesi h1 = new HesapMakinesi(100, 10, "Çarp");
            //HesapMakinesi h2 = new HesapMakinesi(100, 10, "Böl");
            //HesapMakinesi h3 = new HesapMakinesi(100, 10, "Topla");
            //HesapMakinesi h4 = new HesapMakinesi(100, 10, "Çıkar");



            Console.Read();



        }
    }
    //CEVAP3
    class HesapMakinesi
    {
        int Sayi1;
        int Sayi2;

        public HesapMakinesi(int sayi1, int sayi2, string islem)
        {
            this.Sayi1 = sayi1;
            this.Sayi2 = sayi2;
            if (islem=="Topla")
            {
                long sonuc = this.Sayi1 + this.Sayi2;
                Console.WriteLine(sonuc);
            }
            else if (islem == "Çıkar")
            {
                int buyuk = Math.Max(this.Sayi1, this.Sayi2);
                int kucuk = Math.Min(this.Sayi1, this.Sayi2);
                long sonuc = buyuk - kucuk;
                Console.WriteLine(sonuc);
            }
            else if (islem == "Çarp")
            {
                long sonuc = this.Sayi1 * this.Sayi2;
                Console.WriteLine(sonuc);
            }
            else if (islem == "Böl")
            {
                if (this.Sayi2 == 0)
                {
                    Console.WriteLine("Bolen 0 Olamaz !!");
                }
                double sonuc = (double)this.Sayi1 / (double)this.Sayi2;
                Console.WriteLine(sonuc);
            }
        }

        public static long Topla(int s1, int s2)
        {
            long sonuc = s1 + s2;
            return sonuc;
        }
        public static long Carp(int s1, int s2)
        {
            long sonuc = s1 * s2;
            return sonuc;
        }
        public static long Cikar(int s1, int s2)
        {
            int buyuk = Math.Max(s1, s2);
            int kucuk = Math.Min(s1, s2);
            long sonuc = buyuk-kucuk;
            return sonuc;
        }
        public static double Bol(int Bolunen, int Bolen)
        {
            if (Bolen == 0)
            {
                Console.WriteLine("Bolen 0 Olamaz !!");
                return 0;
            }
            double sonuc = (double)Bolunen / (double)Bolen;
            return sonuc;
        }
    }

















    //CEVAP2:
    class Televizyon
    {
        public string Marka;
        public string Model;
        public string Renk;
        public double Fiyat;
        public string Cozunurluk;
        public float EkranBoyutu;
        public double KDVliFiyat;

        public Televizyon()
        {
            Console.WriteLine("Yapıcı Çalıştı!!!");
        }
        ~Televizyon()
        {
            Console.WriteLine("Yıkıcı Metot Çalıştı!!!");
        }
        public Televizyon(string marka, string model, string renk, double fiyat, string cozunurluk, float ekrBoyut)
        {
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.Fiyat = fiyat;
            this.Cozunurluk = cozunurluk;
            this.EkranBoyutu = ekrBoyut;
            this.KDVliFiyat = KDVHesapla();
            Console.WriteLine("Yapıcı Çalıştı!!!");
        }

        public double KDVHesapla()
        {
            this.KDVliFiyat = this.Fiyat * 1.18;
            return this.KDVliFiyat;
        }

    }





    //CEVAP1:
    class Dortgen
    {
        public short mEn;
        public short mBoy;

        public void CevreHesapla()
        {
            int Cevre = (this.mEn + this.mBoy) * 2;
            Console.WriteLine($"Dörtgenin çevresi: {Cevre}");
        }
        public int AlanHesapla(short En, short Boy)
        {
            this.mEn = En;
            this.mBoy = Boy;
            int alan = this.mEn * this.mBoy;
            return alan;
        }
    }
}
