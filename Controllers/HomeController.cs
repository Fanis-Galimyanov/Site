using Microsoft.AspNetCore.Mvc;
using Saite_1.Data.interfaces;
using Saite_1.ViewModels;

namespace Saite_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _allCars;
        public HomeController(IAllCars iAllCars) 
        {
            _allCars = iAllCars;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _allCars.getFavCars
            };
            return View(homeCars);
        }
    }
}
