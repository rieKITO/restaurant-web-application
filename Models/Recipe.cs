using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DishId { get; set; }
        public float CookingTime { get; set; }
        public string CookingTechnology { get; set; }

    }
}
