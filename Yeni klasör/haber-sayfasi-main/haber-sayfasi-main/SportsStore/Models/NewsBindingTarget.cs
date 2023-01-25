using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class NewsBindingTarget
    {
        [Required]
        public string Baslik { get; set; }

        [Range(1, 1000)]
        public string Ozet { get; set; }

        [Range(1, 1000)]
        public string Icerik { get; set; }

        [Range(1, 1000)]
        public string HaberlerinKategorisi { get; set; }

        [Range(1, 1000)]
        public string ResimYol { get; set; }



        public HaberleriEkleModelClass ToNews() => new HaberleriEkleModelClass()
        {
            Baslik = this.Baslik,
            Ozet = this.Ozet,
            Icerik = this.Icerik,
            HaberlerinKategorisi = this.HaberlerinKategorisi,
            ResimYol = this.ResimYol
        };
    }
}
