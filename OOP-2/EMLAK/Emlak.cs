using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLAK
{
    public class Emlak
    {
        public int ID;
        public string Baslik;
        public string Adres;
        public byte OdaSayisi;
        public byte SalonSayisi;
        public float SatisFiyati;
        public float KiraFiyati;
        public short YapimTarihi;

        public Emlak() { }

        public Emlak(int id, string baslik, string adres, byte oda, byte salon, float fiyatS, float fiyatK, short yapimTarihi)
        {
            this.ID = id;
            this.Baslik = baslik;
            this.Adres = adres;
            this.OdaSayisi = oda;
            this.SalonSayisi = salon;
            this.SatisFiyati = fiyatS;
            this.KiraFiyati = fiyatK;
            this.YapimTarihi = yapimTarihi;
            Console.WriteLine("Yapıcı metot çalıştı. Gönderilen parametreler ile yeni nesne oluşturuldu.");
        }
        public void BilgiListele()
        {
            int binaYasi = (short)DateTime.Now.Year - YapimTarihi;

            Console.WriteLine($"ID: {ID}\nBaslık: {Baslik}\nAdres: {Adres}\n Oda Sayısı: {OdaSayisi} Salon Sayısı: {SalonSayisi}\n Satış Fiyatı: {SatisFiyati}\n Kira Fiyatı: {KiraFiyati}\n Bina Yaşı: {binaYasi}\n");
        }
        public void BilgiGuncelle(string baslik = "", string adres = "", byte oda = 0, byte salon = 0, float fiyatS = 0F, float fiyatK = 0F, short yapimTarihi = 0)
        {
            if (baslik != "")
            {
                this.Baslik = baslik;
            }
            if (adres != "")
            {
                this.Adres = adres;
            }
            if (oda != 0)
            {
                this.OdaSayisi = oda;
            }
            if (salon != 0)
            {
                this.SalonSayisi = salon;
            }
            if (fiyatS != 0F)
            {
                this.SatisFiyati = fiyatS;
            }
            if (fiyatK != 0F)
            {
                this.KiraFiyati = fiyatK;
            }
            if (yapimTarihi != 0)
            {
                this.YapimTarihi = yapimTarihi;
            }
            Console.WriteLine("Emlak nesnesine ait bilgiler güncellendi!");
        }

    }
}
