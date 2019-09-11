using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class PotionRecipe
    {
        public PotionRecipe()
        {

        }
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string PotionName { get; set; }
        [Required]
        public Rarity Rarity { get; set; }
        [Required]
        [MaxLength(5000)]
        public string Description { get; set; }
        [Required]
        public int DC { get; set; }
    }
}
