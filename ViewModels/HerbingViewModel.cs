using Herbalist.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.ViewModels
{
    public class HerbingViewModel
    {
        [Required]
        public Rarity? Rarity { get; set; }
        [Required]
        public Location? Location { get; set; }
        [Display(Name = "Add/Remove herbs")]
        public int? Static { get; set; } = 0;
        [Display(Name = "Survival modifier")]
        public int? SurvivalMod { get; set; } = 0;
        [Required]
        public Advantage Advantage { get; set; } = Advantage.Normal;
        public string Message { get; set; }
        public bool IsStatic { get; set; } = false;
    }
}
