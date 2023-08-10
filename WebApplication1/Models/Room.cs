﻿using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Layout { get; set; }
        
    }
}
