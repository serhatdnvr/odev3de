using System;
using System.Collections.Generic;
using System.Text;

namespace odev3de
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id No;" +musteri.MusteriId+"eklenmistir");
        }

        public void Sil (Musteri musteri) 
        {
            Console.WriteLine("ID No:" +musteri.MusteriId + "Silinmistir");
            Console.WriteLine("--------------");
        }


        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {

                Console.WriteLine("Müşteri Ad-Soyad: " + musteri.MusteriAdi + "  " + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri Id: " + musteri.MusteriId);
                

                Console.WriteLine("--------------");
            }
        }
        


    }
}
