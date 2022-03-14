using Microsoft.AspNetCore.Mvc;
using Saite_1.Data.interfaces;
using Saite_1.ViewModels;

namespace Saite_1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategoris;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategoris = iCarsCat;
        }
        public ViewResult List()
        {
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Категории";
            return View(obj);
        }
    }
}
