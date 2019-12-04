using System.Collections.Generic;

namespace iPieShop.Web.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}