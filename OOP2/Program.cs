using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "İsmet";
            gercekMusteri.Soyadi = "Dikici";
            gercekMusteri.TcNo = "111111111";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}