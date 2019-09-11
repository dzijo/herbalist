using Herbalist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.ViewModels
{
    public class HerbViewModel
    {
        public HerbViewModel()
        {

        }
        public HerbViewModel(HerbInfo herb, int count)
        {
            HerbName = herb.HerbName;
            Location = herb.Location;
            Rarity = herb.Rarity;
            DC = herb.DC;
            Count = count;
        }
        public string HerbName { get; set; }
        public Location Location { get; set; }
        public Rarity Rarity { get; set; }
        public int DC { get; set; }
        public int Count { get; set; }
    }
}
