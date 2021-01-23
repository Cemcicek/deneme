using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            // şirket adı nesnesi tasarlanmış ama kullanmamız gerekmiyor -> soyutlama hatası.

            // engin demiroğ kullanıcısı için
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567891";

            // kodlama io girişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123444";


            // Gerçek Müşteri - Tüzel Müşteri (birbirinin yerine kullnılamaz)
            // SOLID - L

            // musteri classı hem gerçekmüşteri hem de tüzelmüşterini referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



            Console.ReadLine();
        }
    }
}
