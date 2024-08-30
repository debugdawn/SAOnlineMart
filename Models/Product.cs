﻿using System.ComponentModel.DataAnnotations;

namespace WebApp2.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

  
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}

