﻿namespace Catalog.API.Models
{
    public class Product
    {
        /// <summary>
        /// "= default!" "varsayılan bir değer ata, ama null uyarılarını görmezden gel" anlamına gelir
        /// </summary>
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default!;
        
        public string ImageFile { get; set; } = default!;
        public decimal Price { get; set; }
    }
}
