using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GercekMusteri customer1 = new GercekMusteri();
            //customer1.Name = "Muhammed";
            //customer1.Surname = "Akkaya";
            //customer1.Id = 01;
            //customer1.TcNo = "22011220021";

            //customer1.CustomerNo = "12345";
            // customer1.SirketName = "?";


            // Gerçek Müşteri -- Tüzel Müşteri
            // SO"L"ID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNo = "01";
            musteri1.Id = 10;
            musteri1.Name = "Muhammed";
            musteri1.Surname = "Akkaya";
            musteri1.TcNo = "22268975222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 11;
            musteri2.SirketName = "Akkaya Holding";
            musteri2.VergiNo = "54632";
            musteri2.CustomerNo = "02";
            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();
            CustemerManager custemerManager = new CustemerManager();
            custemerManager.Add(musteri4);
            custemerManager.Add(musteri3);
            custemerManager.Add(musteri2);
            custemerManager.Add(musteri1);
        }
    }
}
