using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunContext db = new UrunContext();
            var urunler = db.Urunler.Select(i => new UrunModel()
            {
                Fiyat = i.Fiyat,
                UrunAdi =i.UrunAdi,
                Kategori=i.Kategori.KategoriAdi
                

            }).ToList();
            var kategoriler = db.Kategoriler.Select(k=> new {

                k.KategoriAdi,
                k.Urunler
            }).ToList();

            foreach (var item in kategoriler)
            {
                   Console.WriteLine("Kategori {0} ", item.KategoriAdi);
                foreach (var item2 in item.Urunler)
                {
                    Console.WriteLine("urunadi {0} fiyatı {1}", item2.UrunAdi, item2.Fiyat);
                }

            }

            foreach (var item in urunler)
            {
                if (item.Fiyat > 100)
                {
                   // Console.WriteLine(item.UrunAdi +"-"+ item.Kategori +"-"+ item.Fiyat);
                    //db.Kategoriler.Where(p => p.Id == item.Id).Select(p => p.KategoriAdi).FirstOrDefault();
                }
            }
            Console.ReadLine();
        }
    }
}
