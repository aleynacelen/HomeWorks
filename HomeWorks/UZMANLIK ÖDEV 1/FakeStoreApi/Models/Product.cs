using System;

namespace FakeStoreApi.Models;

public class Product
{
    
    
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; }=string.Empty;
        public string ?Category { get; set; }
        public string ?Image { get; set; }
    
}
