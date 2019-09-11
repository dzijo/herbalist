using Herbalist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.ViewModels
{
    public class FullPotionViewModel
    {
        public FullPotionViewModel()
        {

        }
        public FullPotionViewModel(List<PotionViewModel> allPotions, List<PotionViewModel> craftablePotions)
        {
            AllPotions = allPotions;
            CraftablePotions = craftablePotions;
            SelectedPotionId = 0;
            Message = "";
        }

        public List<PotionViewModel> AllPotions { get; set; }
        public List<PotionViewModel> CraftablePotions { get; set; }
        public int SelectedPotionId { get; set; }
        public Advantage Advantage { get; set; } = Advantage.Normal;
        public int? HerbalismMod { get; set; }
        public string Message { get; set; }
    }
}
