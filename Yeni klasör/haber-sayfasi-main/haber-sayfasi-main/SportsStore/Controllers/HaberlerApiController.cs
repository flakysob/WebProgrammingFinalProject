using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HaberlerApiController : ControllerBase
    {
            private StoreDbContext context;
            public HaberlerApiController(StoreDbContext ctx)
            {
                context = ctx;
            }

            [HttpGet]
            public IAsyncEnumerable<HaberleriEkleModelClass> GetNews()
            {
                return context.HaberleriEkleModelClass;
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetNews(int id)
            {
                HaberleriEkleModelClass p = await context.HaberleriEkleModelClass.FindAsync(id);
                if (p == null)
                {
                    return NotFound();
                }
                return Ok(new
                {
                    Baslik = p.Baslik,
                    HaberlerinKategorisi = p.HaberlerinKategorisi,
                    Icerik = p.Icerik,
                    Ozet = p.Ozet,
                    ResimYol = p.ResimYol
                });
            }

            [HttpPost]
            public async Task<IActionResult> SaveNews(NewsBindingTarget target)
            {
                HaberleriEkleModelClass p = target.ToNews();
                await context.HaberleriEkleModelClass.AddAsync(p);
                await context.SaveChangesAsync();
                return Ok(p);
            }

            [HttpPut]
            public async Task UpdateNews(HaberleriEkleModelClass news)
            {
                context.Update(news);
                await context.SaveChangesAsync();
            }

            [HttpDelete("{id}")]
            public async Task DeleteNews(int id)
            {
                context.HaberleriEkleModelClass.Remove(new HaberleriEkleModelClass() { NewsID = id });
                await context.SaveChangesAsync();
            }

            [HttpGet("redirect")]
            public IActionResult Redirect()
            {
                return RedirectToAction(nameof(GetNews), new { Id = 1 });
            }
    }
}

