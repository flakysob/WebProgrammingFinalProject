using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFNewsRepository : INewsRepository
    {
        private StoreDbContext context;

        public EFNewsRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<HaberleriEkleModelClass> Haberler => context.HaberleriEkleModelClass;

        public void CreateNews(HaberleriEkleModelClass n)
        {
            context.Add(n);
            context.SaveChanges();
        }
        public void DeleteNews(HaberleriEkleModelClass n)
        {
            context.Remove(n);
            context.SaveChanges();
        }

        public void SaveNews(HaberleriEkleModelClass n)
        {
            context.SaveChanges();
        }
    }
}
