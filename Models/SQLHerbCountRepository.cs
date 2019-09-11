using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Herbalist.ViewModels;

namespace Herbalist.Models
{
    public class SQLHerbCountRepository : IHerbCountRepository
    {
        private readonly AppDbContext context;

        public SQLHerbCountRepository(AppDbContext context)
        {
            this.context = context;
        }

        public HerbViewModel Add(HerbCount herbCount)
        {
            context.HerbCounts.Add(herbCount);
            context.SaveChanges();
            return new HerbViewModel(context.HerbInfos.Find(herbCount.HerbId), herbCount.Count);
        }

        public HerbCount Delete(int herbId, string userName)
        {
            HerbCount herbCount = context.HerbCounts.Find(herbId, userName);
            if (herbCount != null)
            {
                context.HerbCounts.Remove(herbCount);
                context.SaveChanges();
            }
            return herbCount;
        }

        public IEnumerable<HerbViewModel> GetAllHerbs(string userName)
        {
            var herbCounts = context.HerbCounts.Where(x => x.UserName == userName);
            var herbs = new List<HerbViewModel>();
            foreach (HerbCount h in herbCounts)
            {
                var herbInfo = context.HerbInfos.Find(h.HerbId);
                herbs.Add(new HerbViewModel(herbInfo, h.Count));
            }
            return herbs;
        }

        public HerbCount GetHerb(int herbId, string userName)
        {
            var herbCount = context.HerbCounts.Where(x => x.UserName == userName && x.HerbId == herbId).FirstOrDefault();
            return herbCount;
        }

        public IEnumerable<HerbViewModel> InstantiateHerbs(string userName)
        {
            List<HerbInfo> herbInfos = context.HerbInfos.ToList();
            var herbs = new List<HerbViewModel>();
            foreach (HerbInfo h in herbInfos)
            {
                var herbCount = new HerbCount()
                {
                    HerbId = h.Id,
                    UserName = userName,
                    Count = 0
                };
                herbs.Add(new HerbViewModel(h, herbCount.Count));
                context.HerbCounts.Add(herbCount);
            }
            context.SaveChanges();
            return herbs;
        }

        public HerbViewModel Update(HerbCount herbCount)
        {
            var oldHerbCount = context.HerbCounts.Find(herbCount.HerbId, herbCount.UserName);
            if (oldHerbCount != null)
            {
                oldHerbCount.Count = herbCount.Count;
                context.HerbCounts.Update(oldHerbCount);
                context.SaveChanges();
            }
            var herbInfo = context.HerbInfos.Find(herbCount.HerbId);
            return new HerbViewModel(herbInfo, herbCount.Count);
        }
        public Dictionary<Rarity, int> CountByRarity(string userName)
        {
            var result = new Dictionary<Rarity, int>();

            foreach (Rarity r in Enum.GetValues(typeof(Rarity)))
            {
                if (r != Rarity.Any)
                {
                    var herbs = context.HerbInfos.Where(x => x.Rarity == r);
                    var count = 0;
                    foreach (HerbInfo h in herbs)
                    {
                        count += GetHerb(h.Id, userName).Count;
                    }
                    result.Add(r, count);
                }
            }

            return result;
        }

        public void RemoveHerbsByName(string herbName, int amount, string userName)
        {
            var herb = context.HerbInfos.Where(x => x.HerbName == herbName).FirstOrDefault();
            var herbId = herb.Id;
            var eHerbId = context.HerbInfos.Where(x => x.Rarity == herb.Rarity && x.Location == Location.Extra).Select(x => x.Id).FirstOrDefault();
            var a = context.HerbCounts.Where(x => x.HerbId == herbId && x.UserName == userName).FirstOrDefault().Count;
            context.HerbCounts.Where(x => x.HerbId == eHerbId && x.UserName == userName).FirstOrDefault().Count -= Math.Max(0, amount - a);
            context.HerbCounts.Where(x => x.HerbId == herbId && x.UserName == userName).FirstOrDefault().Count -= Math.Min(a, amount);
            context.SaveChanges();
            return;
        }

        public void RemoveHerbsById(int herbId, int amount, string userName)
        {
            context.HerbCounts.Where(x => x.HerbId == herbId && x.UserName == userName).FirstOrDefault().Count -= amount;
            context.SaveChanges();
            return;
        }
    }
}
