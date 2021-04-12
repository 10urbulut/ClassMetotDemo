using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    public class MusteriManager
    {
        
        public void MusteriEkle(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri eklendi!"+musteri.MusteriAdi+"\n");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi!\n" );
        }
        public void MusterileriListele( Musteri musteri)
        {
          

            //foreach ()
            //{
            //    Console.WriteLine(musteri1.MusteriId);
            //    Console.WriteLine(musteri1.MusteriAdi);
            //    Console.WriteLine(musteri1.MusteriSoyadi + "\n");

            //}
            Console.WriteLine("Müşteriler listelendi!"+musteri.MusteriAdi);

        }
    }
}
