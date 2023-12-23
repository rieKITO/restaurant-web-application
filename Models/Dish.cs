﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public double Weight { get; set; }
        public int RecipeId { get; set; }
        public Image? Image { get; set; } = null!;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
