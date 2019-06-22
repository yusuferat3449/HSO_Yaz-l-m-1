using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             SORU1: 
                3 int parametre alan ve üçgen çevre hesabını 
                yapan metodu değer döndüren ve döndürmeyen 
                2 şekliyle yazınız.
             */
            //CEVAP1:
            UcgenCevreYaz(3, 4, 5);
            UcgenCevreYaz(6, 8, 10);

            int ucgenCevre = UcgenCevreDondur(3, 4, 5);
            Console.WriteLine($"Üçgenin Çevresi: {ucgenCevre} cm'dir.");


            Console.ReadKey();
        }
        //CEVAP1:
        static void UcgenCevreYaz(int k1, int k2, int k3)
        {
            int cevre = k1 + k2 + k3;
            Console.WriteLine($"Üçgenin Çevresi: {cevre} cm'dir.");
        }
        static int UcgenCevreDondur(int k1, int k2, int k3)
        {
            int cevre = k1 + k2 + k3;
            return cevre;
        }
    }
}
