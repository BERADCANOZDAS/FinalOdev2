using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOdev
{
    internal class Ogrenciler
    {
        public int OgrenciId { get; set; }

      
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Numara { get; set; }

        public override string ToString()
        {
            return $"Ad:{this.Ad}-Soyad:{this.Soyad}-Numara:{this.Numara}";
        }
    }
}
