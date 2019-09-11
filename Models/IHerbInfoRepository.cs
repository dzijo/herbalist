using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public interface IHerbInfoRepository
    {
        HerbInfo GetHerbInfo(int Id);
        IEnumerable<HerbInfo> GetAllHerbInfos();
        HerbInfo Add(HerbInfo herbInfo);
        int GetHerbId(Rarity rarity, Location location);
        int GetHerbId(string herbName);
        List<int> GetHerbIdsByRarity(Rarity rarity);
    }
}
