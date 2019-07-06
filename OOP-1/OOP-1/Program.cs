using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            /*
                Arac mazdaRx7 = new Arac();
                mazdaRx7.Marka = "Mazda";
                mazdaRx7.Model = "RX7";
                mazdaRx7.Renk = "Kırmızı";
                mazdaRx7.Mensei = "Japonya";
                mazdaRx7.YakitTuru = "Benzin";
                mazdaRx7.KoltukSayisi = 2;
                mazdaRx7.KapiSayisi = 3;
                mazdaRx7.OrtalamaYakitTuketimi = 8F;
                mazdaRx7.UretimYili = 2019;
                mazdaRx7.MotorHacmi = 2500;

                Console.WriteLine($"Araç Markası : {mazdaRx7.Marka} \nAraç Modeli: {mazdaRx7.Model}");

                mazdaRx7.AraciCalistir(300F);
            */
            }



            //Ogrenci halil = new Ogrenci();
            //DateTime dt = new DateTime(2000, 6, 7);
            //Ogrenci halil = new Ogrenci("Halil TÜRKOĞLU", "45678734566", 78, 87, dt);

            //DateTime dt = new DateTime(2000, 6, 7);
            //halil.OgrenciKaydet("Halil TÜRKOĞLU", "45678734566", 78, 87,dt);

            //halil.OgrenciBilgiListele();


            Ogrenci.NesnesizMetot();

            Console.Read();

        }
    }

    class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public string TCNO;
        public float Not1;
        public float Not2;
        private float NotOrt;

        //public Ogrenci() {
        //    Console.WriteLine("Yeni Öğrenci Oluşturuldu.");
        //}
        // SORU: Televizyon;
        // KDVHesapla(); KDV = Fiyat * 0.18;
        // Yapıcı Metotdunda: "Yeni TV oluşturuldu."
        // Yıkıcı Metotdunda: "Bir TV yok edildi."
        public Ogrenci()
        {
            this.Ad = "NoName";
            this.Soyad = "NoSurName";
            this.Not1 = 0F;
            this.Not2 = 0F;
            this.TCNO = "00000000000";
            DateTime dt = new DateTime(1900, 1, 1);
            this.DogumTarihi = dt;
            this.NotOrt = 0F;
        }
        public Ogrenci(string adSoyad, string tc, float not1, float not2, DateTime dogum)
        {
            string[] adSoyadDizisi = adSoyad.Split(' ');
            this.Ad = adSoyadDizisi[0];
            this.Soyad = adSoyadDizisi[1];
            this.Not1 = not1;
            this.Not2 = not2;
            this.TCNO = tc;
            this.DogumTarihi = dogum;
            this.NotOrt = (not1 + not2) / 2;

        }
        ~Ogrenci()
        {
            Console.WriteLine("YIKICI METOT ÇALIŞTI !!!!");
        }





        public static void NesnesizMetot()
        {
            Console.WriteLine("NESNESİZ METOT ÇALIŞTI!!!");
        }


        public void OgrenciKaydet(string adSoyad,string tc, float not1, float not2,DateTime dogum)
        {
            string[] adSoyadDizisi = adSoyad.Split(' ');
            this.Ad = adSoyadDizisi[0];
            this.Soyad = adSoyadDizisi[1];
            this.Not1 = not1;
            this.Not2 = not2;
            this.TCNO = tc;
            this.DogumTarihi = dogum;
            this.NotOrt = (not1 + not2) / 2;
        }

        public void OgrenciBilgiListele()
        {
            Console.WriteLine($"{this.Ad}\n{this.Soyad}\n{this.TCNO}\n{this.DogumTarihi}\n{this.NotOrt}");
        }

    }


    class Arac
    {
        public string Marka;
        public string Model;
        public string Renk;
        public string Mensei;
        public string YakitTuru;
        public byte KoltukSayisi;
        public byte KapiSayisi;
        public float OrtalamaYakitTuketimi;
        public short UretimYili;
        public short MotorHacmi;

        private float HizLimiti;

        public void AraciCalistir(float limit)
        {
            HizLimiti = limit;
            Console.WriteLine($"{Marka} {Model} Araç Çalıştı.\nHız Limiti: {HizLimiti}");
        }
         
    }

    
}
