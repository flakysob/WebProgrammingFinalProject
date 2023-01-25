using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }

            if (!context.HaberleriEkleModelClass.Any())
            {
                context.HaberleriEkleModelClass.AddRange(
                new HaberleriEkleModelClass
                {
                    Baslik = "TBMM",
                    Ozet = "TBMM Kurul Görüşmeleri",
                    Icerik = "Genel Kurulda, bazı uluslararası anlaşmaların onaylanmasının uygun bulunduğuna dair kanun teklifleri ele alınacak.",
                    HaberlerinKategorisi = "Siyaset",
                    ResimYol = "/img/haber1.jpg"
                },
               new HaberleriEkleModelClass
               {
                   Baslik = "MÜSİAD Genişletilmiş Başkanlar Toplantısı",
                   Ozet = " Hazine ve Maliye Bakanı Nureddin Nebati, MÜSİAD Genişletilmiş Başkanlar Toplantısı'na iştirak edecek.",
                   Icerik = "Hazine ve Maliye Bakanı Nureddin Nebati, Türkiye Milliyetçi İşadamları ve Sanayiciler Derneği (MÜSİAD) Genişletilmiş Başkanlar Toplantısı'na katılacak. Toplantı, Türkiye'nin ekonomik durumu ve gelecekteki fırsatlar hakkında önemli konuları ele alacak. Bakan Nebati, ülkenin ekonomik hedeflerine nasıl ulaşacağını ve iş dünyasının rolünü konuşacak.",
                   HaberlerinKategorisi = "Ekonomi Finans",
                   ResimYol = "/img/haber2.jpg"
               },
               new HaberleriEkleModelClass
               {
                   Baslik = "HARRY’NİN KİTABI SATIŞTA",
                   Ozet = "İngiliz Kraliyet ailesinden ayrılarak ABD'ye yerleşen Prens Harry'nin tartışmalı anı kitabı 'Spare' satışa çıktı",
                   Icerik = "İngiliz Kraliyet ailesinden ayrılarak ABD'ye yerleşen Prens Harry'nin tartışmalı anı kitabı 'Spare' satışa çıktı. Ülke gündemine oturan kitabı satın almak isteyen vatandaşlar kitapçılarda sıraya girdİ. İngilizcenin dışında 15 dilde yayımlanan kitaba, dünya çapında büyük talep olduğu biliniyor.",
                   HaberlerinKategorisi = "Dünyadan Haberler",
                   ResimYol = "/img/haber3.jpg"
               }
            );
                context.SaveChanges();
            }
        }
    }
}
