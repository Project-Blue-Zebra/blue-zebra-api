using System;

namespace blue.zebra.Domain.Catalog{
    
    public class Item{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public decimal Price { get; set; }

        public List<Rating> Ratings { get; set; }

        public void AddRating(Rating rating) {
            this.Ratings.Add(rating);
        }

        public Item(string name, string description, string brand, decimal price){
        if(string.IsNullOrEmpty(name)){
            throw new ArgumentNullException(name);
        }

        if(string.IsNullOrEmpty(description)){
            throw new ArgumentNullException(description);
        }

        if(string.IsNullOrEmpty(brand)){
            throw new ArgumentNullException(brand);
        }

        if(price < 0.00m){
            throw new ArgumentOutOfRangeException("Price must be greater than or equal to 0.");
        }

        this.Name = name;
        this.Description = description;
        this.Brand = brand;
        this.Price = price;
        this.Ratings = new List<Rating>();
        }
        
    }

    
}