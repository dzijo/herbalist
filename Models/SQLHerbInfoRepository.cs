using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class SQLHerbInfoRepository : IHerbInfoRepository
    {
        public SQLHerbInfoRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public HerbInfo Add(HerbInfo herbInfo)
        {
            Context.HerbInfos.Add(herbInfo);
            Context.SaveChanges();
            return herbInfo;
        }

        public IEnumerable<HerbInfo> GetAllHerbInfos()
        {
            return Context.HerbInfos;
        }

        public int GetHerbId(Rarity rarity, Location location)
        {
            return Context.HerbInfos.Where(x => x.Rarity == rarity && x.Location == location).FirstOrDefault().Id;
        }

        public int GetHerbId(string herbName)
        {
            return Context.HerbInfos.Where(x => x.HerbName == herbName).Select(x => x.Id).FirstOrDefault();
        }

        public List<int> GetHerbIdsByRarity(Rarity rarity)
        {
            return Context.HerbInfos.Where(x => x.Rarity == rarity).Select(x=> x.Id).ToList();
        }

        public HerbInfo GetHerbInfo(int Id)
        {
            return Context.HerbInfos.Find(Id);
        }
    }
}
