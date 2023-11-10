namespace OPP1_2;

class Program
{
    static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Ad = "Engin";
        musteri1.Soyad = "Demiroğ";
        musteri1.TcNo = "123456789";
        //kodlama io
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "142323";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "32434434";


        //gerçek müşteri - tüzel müşteri

        //SOLID 

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(musteri1);
        customerManager.Add(musteri2);

        Console.ReadLine();
    }
}

