using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class HerbAmount
    {
        public HerbAmount()
        {

        }
        public HerbAmount(int amount, int herbId, int potionId, int id)
        {
            HerbId = herbId;
            Amount = amount;
            PotionId = potionId;
            Id = id;
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int HerbId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int PotionId { get; set; }
    }
}
