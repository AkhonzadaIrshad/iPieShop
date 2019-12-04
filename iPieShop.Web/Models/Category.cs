using System.Collections.Generic;

namespace iPieShop.Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<Pie> Pies { get; set; }
    }
}