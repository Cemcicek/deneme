using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // classın Örneği
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // Dizi oluştuluruldu
            Urun[] urunler = new Urun[]  {urun1, urun2 };

            //(veri tipi) (takma ad) in (kullanılan dizi)
            foreach (var urun in urunler)
            {   
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------------Metotlar----------");
            // instance - örnek
            // encapsulation - kapsülleme
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut",  "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma",   "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarnakır karpuz", 12, 8);

            Console.ReadLine();
        }
    }
}
