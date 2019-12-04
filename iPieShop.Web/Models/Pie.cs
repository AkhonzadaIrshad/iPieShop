using System;
using System.Linq;
using System.Threading.Tasks;

namespace iPieShop.Web.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
