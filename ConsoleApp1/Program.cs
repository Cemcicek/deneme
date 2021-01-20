using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "PHP";
            kurs2.egitmen = "İlker yaz";
            kurs2.izlenmeOranı = 78;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "C++";
            kurs3.egitmen = "Bilgi güneş";
            kurs3.izlenmeOranı = 100;

            kurs[] kurslar = new kurs[] { 
            
                kurs1, kurs2, kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+ " : " + kurs.egitmen);
            }

            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        class kurs
        {
            public string kursAdi { get; set; }
            public string egitmen { get; set; }
            public int izlenmeOranı { get; set; }
        }
    }
}
