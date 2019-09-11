using Herbalist.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public interface IPotionRepository
    {
        List<PotionViewModel> GetAllPotions();
        List<PotionViewModel> GetCraftablePotions(List<PotionViewModel> allPotions, Dictionary<Rarity, int> herbsByRarity, string userName);
        bool IsCraftable(PotionViewModel potion, Dictionary<Rarity, int> herbsByRarity, string userName);
    }
}
