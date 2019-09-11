using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class HerbCount
    {
        [Required]
        public int HerbId { get; set; }
        [Required]
        [MaxLength(256)]
        public string UserName { get; set; }
        public int Count { get; set; }
    }
}
