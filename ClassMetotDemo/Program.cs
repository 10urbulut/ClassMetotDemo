using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassMetotDemo
{
    public class Program
    {
        
       public static void Main(string[] args)
        {      
            // müşteri veritabanı oluşturuyoruz
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 101;
            musteri1.MusteriAdi = "Onur";
            musteri1.MusteriSoyadi = "BULUT";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 102;
            musteri2.MusteriAdi = "Aydın";
            musteri2.MusteriSoyadi = "SARUHAN";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 103;
            musteri3.MusteriAdi = "Ceylan";
            musteri3.MusteriSoyadi = "ERTEM";

            //ürünlerimizi foreach döngüsü ile listeliyoruz
            Console.WriteLine("\n-----Ürünlerin listesi-----\n");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musterilistesi in musteriler)
            { 
                Console.WriteLine(musterilistesi.MusteriId);
                Console.WriteLine(musterilistesi.MusteriAdi);
                Console.WriteLine(musterilistesi.MusteriSoyadi+"\n");
               // normalde bu formul metodun içinde oluyor
            }


            Console.WriteLine("\n-------Metotlar-------\n");

            MusteriManager musteriManager = new MusteriManager();

            //simulasyon ekleme
            musteriManager.MusteriEkle(musteri1);

            //simulasyonda böyle listeledim asıl listeleme foreach ile en başta oluyor
            //burada overloading olduğu için tek tek yaptım
            musteriManager.MusterileriListele(musteri1);
            musteriManager.MusterileriListele(musteri2);
            musteriManager.MusterileriListele(musteri3);


            //simulasyon silme
            musteriManager.MusteriSil(musteri2);


            Console.ReadLine();


        }
    }
}
