using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı");
        }
    }
}
