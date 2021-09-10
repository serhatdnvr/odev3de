using System;

namespace odev3de
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri() { MusteriAdi = "serhat", MusteriSoyadi = "pekyemez" ,MusteriId=232, TcNo=321654 };
            Musteri Musteri2 = new Musteri() {MusteriAdi="resul",MusteriSoyadi="Tatlises" ,MusteriId=777, TcNo=656531 };

          

            Musteri[] musteriler = new Musteri[] { Musteri1,Musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("musteri adi:"+ musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
                Console.WriteLine("musteri Id'si:"+ musteri.MusteriId);
                Console.WriteLine("musteri tcsi:"+ musteri.TcNo);
                Console.WriteLine("-----------------");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(Musteri1);
            musteriManager.Sil(Musteri2);
            musteriManager.Listele(musteriler);











        }
    }
}
