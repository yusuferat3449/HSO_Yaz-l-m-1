using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarihZaman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now); // Şimdiki Zaman
            //Console.WriteLine(DateTime.Today); // Bugün
            //Console.WriteLine(DateTime.MinValue); // En Küçük Değeri
            //Console.WriteLine(DateTime.MaxValue); // En Büyük Değeri

            //DateTime tarihsaat = new DateTime();

            //tarihsaat = DateTime.Now;


            //Console.WriteLine($"Gün: {tarihsaat.Day}");
            //Console.WriteLine($"Gün: {tarihsaat.DayOfWeek}");
            //Console.WriteLine($"Gün: {tarihsaat.DayOfYear}");

            //Console.WriteLine($"Gün: {tarihsaat.Second}");
            //Console.WriteLine($"Gün: {tarihsaat.Minute}");
            //Console.WriteLine($"Gün: {tarihsaat.Hour}");

            //Console.WriteLine($"Gün: {tarihsaat.ToShortDateString()}");
            //Console.WriteLine($"Gün: {tarihsaat.Year}");

            //string simdi = tarihsaat.ToString("dd/MM/yyyy");
            //Console.WriteLine(simdi);
            //simdi = tarihsaat.ToString("dd/MM/yyyy HH:mm:ss");
            //Console.WriteLine(simdi);

            DateTime tarihsaat = new DateTime();
            tarihsaat = DateTime.Now;
            DateTime dogumGunu = new DateTime(2007, 11, 24);
            //Console.WriteLine(dogumGunu.ToString("dd.MM.yyyy"));

            TimeSpan gecenZaman = tarihsaat - dogumGunu;
            Console.WriteLine(gecenZaman.Days);


            



            Console.Read();
            
        }
    }
}
