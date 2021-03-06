using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShipAPI.Models
{
    public class Location
    {
        public int Id { get; set; }

        [NotMapped]
        public string BrandName => Franchise != null ? Franchise.Brand : "No name found";

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }

        public string PhoneNumber { get; set; }

        public PriceRange PriceRange { get; set; }

        public float AverageRating { get; set; } = 0;

        public string ImageUrl { get; set; }

        public int FranchiseId { get; set; }

        public Franchise Franchise { get; set; }

        public List<Rating> Ratings { get; set; } = new List<Rating>();
     
    }
}