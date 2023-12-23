using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public float CaloricValue { get; set; }
        public float Weight { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
