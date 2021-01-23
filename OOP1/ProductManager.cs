using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // encapsulation
                        // (string ad) gibi.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }






        // program akışında tekrar kullanabiliriz
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }

        //  void - ekrana yazdırır sadece, git yap bitir. 
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
