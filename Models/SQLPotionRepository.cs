using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Herbalist.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Herbalist.Models
{
    public class SQLPotionRepository : IPotionRepository
    {
        private readonly AppDbContext context;

        public SQLPotionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public List<PotionViewModel> GetAllPotions()
        {
            var recipes = context.PotionRecipes.AsNoTracking().ToList();
            var herbInfos = context.HerbInfos.AsNoTracking().ToList();
            var allHerbs = context.Herbs.AsNoTracking().ToList();

            List<PotionViewModel> result = new List<PotionViewModel>();

            foreach (var recipe in recipes)
            {
                List<HerbAmount> herbs = allHerbs.Where(x => x.PotionId == recipe.Id).ToList();
                //List<HerbAmount> herbs = context.Herbs.Where(x => x.PotionId == recipe.Id).ToList();
                var herbAmountViewList = new List<HerbAmountViewModel>();
                foreach (HerbAmount h in herbs)
                {
                    string herbName;
                    if (h.HerbId <= 0)
                    {
                        herbName = ((Rarity)(-h.HerbId - 1)).ToString();
                    }
                    else
                    {
                        herbName = herbInfos.Where(x => x.Id == h.HerbId).Select(x => x.HerbName).FirstOrDefault();
                        //herbName = context.HerbInfos.Find(h.HerbId).HerbName;
                    }
                    herbAmountViewList.Add(new HerbAmountViewModel()
                    {
                        Amount = h.Amount,
                        HerbName = herbName
                    });
                }

                result.Add(new PotionViewModel(recipe, herbAmountViewList));
            }

            return result;
        }

        public List<PotionViewModel> GetCraftablePotions(List<PotionViewModel> allPotions, Dictionary<Rarity, int> herbsByRarity, string userName)
        {
            var craftablePotions = new List<PotionViewModel>();
            var herbInfos = context.HerbInfos.AsNoTracking().ToList();
            var herbCounts = context.HerbCounts.AsNoTracking().ToList();

            foreach (var potion in allPotions)
            {
                bool craftable = true;
                foreach (var herb in potion.Herbs)
                {
                    if (new[] { "Common", "Uncommon", "Rare", "VeryRare" }.Contains(herb.HerbName))
                    {
                        switch (herb.HerbName)
                        {
                            case "Common":
                                if (herbsByRarity[Rarity.Common] < herb.Amount) craftable = false;
                                break;
                            case "Uncommon":
                                if (herbsByRarity[Rarity.Uncommon] < herb.Amount) craftable = false;
                                break;
                            case "Rare":
                                if (herbsByRarity[Rarity.Rare] < herb.Amount) craftable = false;
                                break;
                            case "VeryRare":
                                if (herbsByRarity[Rarity.VeryRare] < herb.Amount) craftable = false;
                                break;
                        }
                    }
                    else
                    {
                        var herbInfo = herbInfos.Where(x => x.HerbName == herb.HerbName).FirstOrDefault();
                        var herbId = herbInfo.Id;
                        var eHerbId = herbInfos.Where(x => x.Rarity == herbInfo.Rarity && x.Location == Location.Extra).FirstOrDefault().Id;
                        var herbCount = herbCounts.Where(x => x.HerbId == herbId && x.UserName == userName).FirstOrDefault().Count;
                        var eHerbCount = herbCounts.Where(x => x.HerbId == eHerbId && x.UserName == userName).FirstOrDefault().Count;
                        if (herbCount + eHerbCount < herb.Amount)
                        {
                            craftable = false;
                            break;
                        }
                    }
                }
                if (craftable)
                {
                    craftablePotions.Add(potion);
                }
            }
            return craftablePotions;
        }

        public bool IsCraftable(PotionViewModel potion, Dictionary<Rarity, int> herbsByRarity, string userName)
        {
            var herbInfos = context.HerbInfos.AsNoTracking().ToList();
            var herbCounts = context.HerbCounts.AsNoTracking().ToList();

            bool craftable = true;
            foreach (var herb in potion.Herbs)
            {
                if (new[] { "Common", "Uncommon", "Rare", "VeryRare" }.Contains(herb.HerbName))
                {
                    switch (herb.HerbName)
                    {
                        case "Common":
                            if (herbsByRarity[Rarity.Common] < herb.Amount) craftable = false;
                            break;
                        case "Uncommon":
                            if (herbsByRarity[Rarity.Uncommon] < herb.Amount) craftable = false;
                            break;
                        case "Rare":
                            if (herbsByRarity[Rarity.Rare] < herb.Amount) craftable = false;
                            break;
                        case "VeryRare":
                            if (herbsByRarity[Rarity.VeryRare] < herb.Amount) craftable = false;
                            break;
                    }
                }
                else
                {
                    var herbInfo = herbInfos.Where(x => x.HerbName == herb.HerbName).FirstOrDefault();
                    var herbId = herbInfo.Id;
                    var eHerbId = herbInfos.Where(x => x.Rarity == herbInfo.Rarity && x.Location == Location.Extra).FirstOrDefault().Id;
                    var herbCount = herbCounts.Where(x => x.HerbId == herbId && x.UserName == userName).FirstOrDefault().Count;
                    var eHerbCount = herbCounts.Where(x => x.HerbId == eHerbId && x.UserName == userName).FirstOrDefault().Count;
                    if (herbCount + eHerbCount < herb.Amount)
                    {
                        craftable = false;
                        break;
                    }
                }
            }
            return craftable;
        }
    }
}
