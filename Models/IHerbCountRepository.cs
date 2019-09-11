using Herbalist.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public interface IHerbCountRepository
    {
        HerbCount GetHerb(int herbId, string userName);
        IEnumerable<HerbViewModel> GetAllHerbs(string userName);
        HerbViewModel Add(HerbCount herbCount);
        HerbViewModel Update(HerbCount herbCount);
        HerbCount Delete(int herbId, string userName);
        IEnumerable<HerbViewModel> InstantiateHerbs(string userName);
        Dictionary<Rarity, int> CountByRarity(string userName);
        void RemoveHerbsByName(string herbName, int amount, string userName);
        void RemoveHerbsById(int herbId, int amount, string userName);
    }
}
