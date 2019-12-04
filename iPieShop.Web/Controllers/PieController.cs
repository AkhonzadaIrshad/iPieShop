using iPieShop.Web.Models;
using iPieShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iPieShop.Web.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _iPieRepository;
        private readonly ICategoryRepository _iCategoryRepository;

        public PieController(IPieRepository iPieRepository,ICategoryRepository iCategoryRepository)
        {
            _iPieRepository = iPieRepository;
            _iCategoryRepository = iCategoryRepository;
        }

        [HttpGet]
        public ActionResult List()
        {
            var data = new PieListViewModel()
            {
                Pies = _iPieRepository.GetPies(),
                SelectedCategory = "SOME SELECTED CATEGORY"
            };
            return View(data);
        }
        
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var data = _iPieRepository.GetPie(id);

            return View(data);
        }
    }
}
