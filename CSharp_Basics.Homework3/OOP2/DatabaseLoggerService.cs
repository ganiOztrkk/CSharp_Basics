using System;
namespace OOP1_3
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}

