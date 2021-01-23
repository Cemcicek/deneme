using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
