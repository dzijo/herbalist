using Herbalist.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.ViewModels
{
    public class PotionViewModel
    {
        public PotionViewModel()
        {

        }
        public PotionViewModel(PotionRecipe recipe, List<HerbAmountViewModel> herbs)
        {
            Id = recipe.Id;
            PotionName = recipe.PotionName;
            Rarity = recipe.Rarity;
            Description = recipe.Description;
            DC = recipe.DC;
            Herbs = herbs;
        }
        public int Id { get; set; }
        public string PotionName { get; set; }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }
        public int DC { get; set; }
        public List<HerbAmountViewModel> Herbs { get; set; }
    }
}
