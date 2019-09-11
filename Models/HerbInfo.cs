using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class HerbInfo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string HerbName { get; set; }
        [Required]
        public Location Location { get; set; }
        [Required]
        public Rarity Rarity { get; set; }
        [Required]
        public int DC { get; set; }
    }
}
