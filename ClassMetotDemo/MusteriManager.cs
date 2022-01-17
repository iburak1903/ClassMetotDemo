using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
       public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeye eklendi: " + musteri.AdSoyad + " -"+" Müşteri Yaş: " + musteri.Yas +" -" +" Müşteri Id:" + musteri.Id);

        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeden silindi:" + musteri.AdSoyad + " -" + " Müşteri Yaş : " + musteri.Yas + " -" + " Müşteri Id: " + musteri.Id);
        }
        public void Listeleme(Musteri[] musteriler)
        {
            foreach (var müsteri in musteriler)
            {
                Console.WriteLine(" Müşteri Adı: "+müsteri.AdSoyad + " -"+ " Müşteri Yaş: " +  müsteri.Yas+ " -"+" Müşteri Id: " + müsteri.Id);
            }
        }
    }
}
