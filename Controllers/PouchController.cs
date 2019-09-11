using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Herbalist.Models;
using Herbalist.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Herbalist.Controllers
{
    [Authorize]
    public class PouchController : Controller
    {
        private readonly IHerbCountRepository herbCountRepository;
        private readonly IHerbInfoRepository herbInfoRepository;
        private readonly IPotionRepository potionRepository;
        Random rand;

        public PouchController(IHerbCountRepository herbCountRepository, IHerbInfoRepository herbInfoRepository, IPotionRepository potionRepository)
        {
            this.herbCountRepository = herbCountRepository;
            this.herbInfoRepository = herbInfoRepository;
            this.potionRepository = potionRepository;
            rand = new Random();
        }

        public IActionResult List()
        {
            var model = herbCountRepository.GetAllHerbs(User.Identity.Name);
            return View(model);
        }

        [HttpGet]
        public IActionResult Herb()
        {
            var model = new HerbingViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Herb(HerbingViewModel model)
        {
            if (!model.Static.HasValue) model.Static = 0;
            if (!model.SurvivalMod.HasValue) model.SurvivalMod = 0;

            if (model.Location == null || model.Rarity == null)
            {
                model.IsStatic = false;
                return View(model);
            }

            Location location = (Location)model.Location;
            Rarity rarity = (Rarity)model.Rarity;
            if (model.IsStatic)
            {
                int herbId;
                HerbCount herbCount;
                if (rarity == Rarity.Any)
                {
                    foreach (Rarity r in Enum.GetValues(typeof(Rarity)))
                    {
                        if (r != Rarity.Any)
                        {
                            herbId = herbInfoRepository.GetHerbId(r, location);
                            herbCount = herbCountRepository.GetHerb(herbId, User.Identity.Name);
                            herbCount.Count += (int)model.Static;
                            herbCountRepository.Update(herbCount);
                        }
                    }
                    model.Message = string.Format("You have added {0} pieces of every {1} herb to your pouch!", model.Static, location);
                }
                else
                {
                    herbId = herbInfoRepository.GetHerbId((Rarity)model.Rarity, location);
                    herbCount = herbCountRepository.GetHerb(herbId, User.Identity.Name);
                    herbCount.Count += (int)model.Static;
                    herbCountRepository.Update(herbCount);
                    model.Message = string.Format("You have added {0} pieces of {1} to your pouch!", model.Static, herbInfoRepository.GetHerbInfo(herbId).HerbName);
                }


                return View(model);
            }
            else
            {
                int roll = rand.Next(1, 21);
                var advantage = model.Advantage;
                var mod = model.SurvivalMod;
                if (advantage == Advantage.Disadvantage) roll = Math.Min(roll, rand.Next(1, 21));
                else if (advantage == Advantage.Advantage) roll = Math.Max(roll, rand.Next(1, 21));

                int herbId = 0;
                int amount = 0;

                switch (rarity)
                {
                    case Rarity.Any:
                        Rarity temp;
                        if (roll + mod >= 10)
                        {
                            if (roll + mod >= 20)
                            {
                                temp = (Rarity)rand.Next(0, 4);
                            }
                            else if (roll + mod >= 16)
                            {
                                temp = (Rarity)rand.Next(0, 3);
                            }
                            else if (roll + mod >= 13)
                            {
                                temp = (Rarity)rand.Next(0, 2);
                            }
                            else
                            {
                                temp = Rarity.Common;
                            }
                            (herbId, amount) = Herb(temp, location);
                        }
                        break;
                    case Rarity.VeryRare:
                        if (roll + mod >= 20)
                        {
                            (herbId, amount) = Herb(rarity, location);
                        }
                        break;
                    case Rarity.Rare:
                        if (roll + mod >= 16)
                        {
                            (herbId, amount) = Herb(rarity, location);
                        }
                        break;
                    case Rarity.Uncommon:
                        if (roll + mod >= 13)
                        {
                            (herbId, amount) = Herb(rarity, location);
                        }
                        break;
                    case Rarity.Common:
                        if (roll + mod >= 10)
                        {
                            (herbId, amount) = Herb(rarity, location);
                        }
                        break;
                }

                model.Message = string.Format("You rolled {0} ({1} + {2}).", roll + mod, roll, mod);
                if (herbId == 0)
                {
                    model.Message += "\nSorry, you failed.";
                }
                else
                {
                    model.Message += string.Format("\nCongrats! You have added {0} pieces of {1} to your pouch!", amount, herbInfoRepository.GetHerbInfo(herbId).HerbName);
                }
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Brew()
        {
            var allPotions = potionRepository.GetAllPotions();
            var model = new FullPotionViewModel
            {
                AllPotions = allPotions,
                CraftablePotions = potionRepository.GetCraftablePotions(allPotions, herbCountRepository.CountByRarity(User.Identity.Name), User.Identity.Name)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Brew(FullPotionViewModel model)
        {
            if (model.HerbalismMod == null) model.HerbalismMod = 0;
            var allPotions = potionRepository.GetAllPotions();
            model.AllPotions = allPotions;
            var potion = allPotions.Where(x => x.Id == model.SelectedPotionId).FirstOrDefault();
            var userName = User.Identity.Name;
            var herbsByRarity = herbCountRepository.CountByRarity(userName);
            if (!potionRepository.IsCraftable(potion, herbsByRarity, userName))
            {
                model.CraftablePotions = potionRepository.GetCraftablePotions(allPotions, herbsByRarity, userName);
                model.Message = "You can't brew that potion! Stop pressing the refresh button!";
                return View(model);
            }
            RemoveHerbs(potion);
            model.CraftablePotions = potionRepository.GetCraftablePotions(allPotions, herbsByRarity, userName);

            int roll = rand.Next(1, 21);
            var advantage = model.Advantage;
            var mod = model.HerbalismMod;
            if (advantage == Advantage.Disadvantage) roll = Math.Min(roll, rand.Next(1, 21));
            else if (advantage == Advantage.Advantage) roll = Math.Max(roll, rand.Next(1, 21));

            model.Message = string.Format("You rolled {0} ({1} + {2}).", roll + mod, roll, mod);

            if (roll >= potion.DC)
            {
                model.Message += string.Format("\nCongrats! You have successfully brewed a {0}!", potion.PotionName);
            }
            else
            {
                model.Message += "\nSorry, you have failed to brew a potion.";
            }

            return View(model);
        }

        public (int, int) Herb(Rarity rarity, Location location)
        {
            var herbId = herbInfoRepository.GetHerbId(rarity, location);
            var herbCount = herbCountRepository.GetHerb(herbId, User.Identity.Name);
            var amount = rand.Next(1, 5);
            herbCount.Count += amount;
            herbCountRepository.Update(herbCount);
            return (herbId, amount);
        }

        public void RemoveHerbs(PotionViewModel potion)
        {
            var userName = User.Identity.Name;

            foreach (var herb in potion.Herbs)
            {
                if (new[] { "Common", "Uncommon", "Rare", "VeryRare" }.Contains(herb.HerbName))
                {
                    var ids = herbInfoRepository.GetHerbIdsByRarity((Rarity)Enum.Parse(typeof(Rarity), herb.HerbName, true));
                    List<int> finalIds = new List<int>();                    
                    foreach (var id in ids)
                    {
                        int count = herbCountRepository.GetHerb(id, userName).Count;
                        finalIds.AddRange(Enumerable.Repeat(id, count));
                    }
                    finalIds.Sort((a, b) => rand.Next(-1, 2));
                    finalIds = finalIds.Take(herb.Amount).ToList();
                    foreach(var id in finalIds)
                    {
                        herbCountRepository.RemoveHerbsById(id, 1, userName);
                    }
                }
                else
                {
                    herbCountRepository.RemoveHerbsByName(herb.HerbName, herb.Amount, userName);
                }
            }

            return;
        }
    }
}