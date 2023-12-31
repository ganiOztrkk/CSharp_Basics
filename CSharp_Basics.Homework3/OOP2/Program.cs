﻿namespace OOP1_3;

class Program
{
    static void Main(string[] args)
    {
        //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        //ihtiyacKrediManager.Hesapla();

        //TasitKrediManager tasitKrediManager = new TasitKrediManager();
        //tasitKrediManager.Hesapla();

        //KonutKrediManager konutKrediManager = new KonutKrediManager();
        //konutKrediManager.Hesapla();

        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

        IKrediManager tasitKrediManager = new TasitKrediManager();
      
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        Console.ReadLine();
    }
}

