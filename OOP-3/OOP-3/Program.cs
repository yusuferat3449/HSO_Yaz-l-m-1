using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortgen d1 = new Dortgen();
            d1.En = 50;

            // Aşağıda atadığımız değer 100 den büyük olduğu içiin setter 100 ataması yapacaktır.
            d1.Boy = 900;
            // Aşağıdaki özellikte set tanımlanmadığı için atama yapamayız.
            //d1.Test = 90;
            Console.WriteLine($"Dörtgenin eni : {d1.En}");
            Console.WriteLine($"Dörtgenin boyu : {d1.Boy}");

            // Test özelliğinin get'terı tanımlandığı için ulaşabiliriz.
            // Değer yapıcı metotda tanımlanmıştır.
            Console.WriteLine($"Dörtgenin Test özelliği : {d1.Test}");

            Console.Read();
        }
    }
    // get set anahtar sözcükleri
    public class Dortgen
    {

        // Aşağıdaki 2 En tanımalaması aynıdır.
        // Tek satır olan aslında üsstteki ile aynı işlemi görür.

        //public int En
        //{
        //    get { return En; }
        //    set { En = value; }
        //}
        //public int En;

        private int pEn;
        // pEn private özelliğine dolaylı erişim.
        public int En
        {
            get { return pEn;}
            set
            {
                if (value>100)
                {
                    pEn = 100;
                }
                else if (value<=0)
                {
                    pEn = 1;
                }
                else
                {
                    pEn = value;
                }
                
            }
        }


        private int pBoy;
        // pBoy private özelliğine dolaylı erişim.
        public int Boy
        {
            get { return pBoy; }
            set
            {
                if (value>100)
                {
                    pBoy = 100;
                }
                else if (value<=0)
                {
                    pBoy = 1;
                }else
                {
                    pBoy = value;
                }
            }
        }


        // Sadece okunabilir özellik.
        private int pTest;

        public int Test
        {
            get { return pTest; }

        }
        public Dortgen()
        {
            this.pTest = 58;
        }



    }
}
