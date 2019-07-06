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

            Console.Read();

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
