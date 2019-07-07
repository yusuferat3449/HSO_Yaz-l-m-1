using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEPTELEFONU
{
    public class CepTelefonu
    {
        public int ID;
        public string IsletimSistemi;
        public string EkranBoyutu;
        public string EkranCozunuluk;
        public float Fiyat;
        public byte GarantiSuresi;

        public CepTelefonu()
        {
            Console.WriteLine("Parametresiz Nesne Oluşturuldu.");
        }
        public CepTelefonu(int id, string isletimSistemi, string ekranBoyutu, string ekranCozunurluk, float fiyat, byte garantiSuresi)
        {
            this.ID = id;
            this.IsletimSistemi = isletimSistemi;
            this.EkranBoyutu = ekranBoyutu;
            this.EkranCozunuluk = ekranCozunurluk;
            this.Fiyat = fiyat;
            this.GarantiSuresi = garantiSuresi;
            Console.WriteLine("Parametreli Nesne Oluşturuldu.");
        }
        public void BilgiListele()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.IsletimSistemi);
            Console.WriteLine(this.EkranBoyutu);
            Console.WriteLine(this.EkranCozunuluk);
            Console.WriteLine(this.Fiyat);
            Console.WriteLine(this.GarantiSuresi + " ay");
        }
        public void BilgiGuncelle(string isletimSistemi = "", string ekranBoyutu = "", string ekranCozunurluk = "", float fiyat = 0F, byte garantiSuresi = 0)
        {
            if (isletimSistemi != "")
            {
                this.IsletimSistemi = isletimSistemi;

            }
            if (ekranBoyutu != "")
            {
                this.EkranBoyutu = ekranBoyutu;
            }
            if (ekranCozunurluk != "")
            {
                this.EkranCozunuluk = ekranCozunurluk;

            }
            if (fiyat != 0F)
            {
                this.Fiyat = fiyat;
            }
            if (garantiSuresi != 0F)
            {
                this.GarantiSuresi = garantiSuresi;

            }
            Console.WriteLine("Nesne Güncellendi.");
        }
        public void GarantiUzat(byte ay)
        {
            this.GarantiSuresi += ay;
        }


    }
}
