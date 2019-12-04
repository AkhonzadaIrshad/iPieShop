using System.Collections.Generic;
using iPieShop.Web.Models;

namespace iPieShop.Web.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string SelectedCategory { get; set; }
    }
}
