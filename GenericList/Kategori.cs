﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
   public  class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }


        //burası program anında kullanılacak
        public List<Urun> Urunler { get; set; }
    }
     
}
