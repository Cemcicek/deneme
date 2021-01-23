using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // mobilyaya karşılık geliyor gibi
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            // PascalCase  / camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           
            
            
            
            // void kullanırken geriye değer döndürmez .
            productManager.Topla2(3, 6);

            // public int yazılanı program akışında tekrar kullanabiliriz.
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu * 2);

            Console.ReadLine();
        }
    }
}
