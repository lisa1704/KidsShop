using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsShop.Models
{
    public class Product
    {
        public Guid id { get; set; }
        public String name { get; set; }
        public int categoryId { get; set; }
        public String categoryName { get; set; }
        public float averageRating { get; set; }
        public int numberOfRaters { get; set; }


    }
}
