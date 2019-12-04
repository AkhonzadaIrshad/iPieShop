using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iPieShop.Web.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPie(int id)
        {
            return _appDbContext.Pies.Find(id);
        }
    }
}
