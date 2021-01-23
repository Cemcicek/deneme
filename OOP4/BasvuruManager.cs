using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {
        // method injection - hangi kredi hangi logger olacağına 
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //başvuru bilgilerini değerlendirme
            
            krediManager.Hesapla();
            foreach (var loggerservice in loggerService)
            {
                loggerservice.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
