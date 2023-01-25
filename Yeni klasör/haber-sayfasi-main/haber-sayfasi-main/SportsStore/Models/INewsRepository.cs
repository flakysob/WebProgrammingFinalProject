using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface INewsRepository
    {
        IQueryable<HaberleriEkleModelClass> Haberler { get; }

        void SaveNews(HaberleriEkleModelClass n);
        void CreateNews(HaberleriEkleModelClass n);
        void DeleteNews(HaberleriEkleModelClass n);
    }
}
