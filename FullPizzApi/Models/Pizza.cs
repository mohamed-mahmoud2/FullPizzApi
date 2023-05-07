﻿namespace FullPizzApi.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
