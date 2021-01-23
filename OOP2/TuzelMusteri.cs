using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras inheritance tuzelmusteri bir müşteri demektir.
   // musteride ki özellikler tüzel musteride de vardır
   // Müsteri ebeveyn
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
