using Saite_1.Data.Models;
using System.Collections.Generic;

namespace Saite_1.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
