using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - hazır kodlar
    //product - ürün
    //unitPrice - fiyatı
    //UnitsInStock - stok adedi
    // CRUD - create r update delete - operasyonları
    class Product
    {
        public int Id { get; set; } //PK
        public int CategoryId { get; set; } //FK
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
