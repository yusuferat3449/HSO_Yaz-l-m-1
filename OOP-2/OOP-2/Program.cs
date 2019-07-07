using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMLAK;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlak ev1 = new Emlak(1, "Aileye Kiralık", "Kadıköy", 3, 1, 0, 1400F, 2009); ;
            Emlak ev2 = new Emlak(2, "Öğrenciye Kiralık", "Kadıköy", 2, 1, 0, 900F, 2008);

            ev1.BilgiListele();
            ev1.BilgiGuncelle(adres: "Sarıyer");
            ev1.BilgiListele();

            Console.Read();
        }
    }
}
