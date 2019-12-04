using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iPieShop.Web.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetPies();
        Pie GetPie(int id);
    }
}
