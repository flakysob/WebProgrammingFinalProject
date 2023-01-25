using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class HaberlerModelClass
    {
        [Key]
        public int newsId { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public string HaberlerinKategorisi { get; set; }
        public string ResimYol { get; set; }
    }
}
