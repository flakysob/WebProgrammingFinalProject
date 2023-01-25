using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class HaberleriEkleModelClass
    {
        [Key]
        public int NewsID { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public string HaberlerinKategorisi { get; set; }
        
        //public IFormFile Resim { get; set; }
        public string ResimYol { get; set; } //img/fotoğrafismi
        
    }
}
