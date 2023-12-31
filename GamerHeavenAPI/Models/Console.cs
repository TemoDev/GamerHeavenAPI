﻿using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models
{
    public class Console
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; } = "Consoles";
        public string Brand { get; set; }
        public string ReleaseDate { get; set; }
        public string Processor { get; set; }
        public string InternalMemory { get; set; }
        public string Ram { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public ICollection<Controller> Controllers { get; set; } = new List<Controller>();

    }
}
