using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Column yazıp (ctrl + .) yaparak eklenir
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName ="varchar")] //kullanılmak istenen fieldın üzerine yazılır
        [MaxLength(20)]
        [Required]
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Numara { get; set; }

        public override string ToString()
        {
            return $"Ad:{this.Ad}-Soyad:{this.Soyad}-Numara:{this.Numara}";
        }
    }
}
