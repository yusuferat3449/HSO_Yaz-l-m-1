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
            Dortgen d1 = new Dortgen();

            d1.En = 5;
            d1.Boy = 10;
            d1.CevreHesapla();
            Console.WriteLine("Dortgenin Alanı: " + d1.AlanHesapla(6,7));

            Console.Read();
        }
    
    }

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
