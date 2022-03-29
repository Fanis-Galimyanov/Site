using Microsoft.EntityFrameworkCore;
using Saite_1.Data.interfaces;
using Saite_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saite_1.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDbContent;
        public CarRepository(AppDBContent appDbContent) 
        {
            this._appDbContent = appDbContent;
        }
        public IEnumerable<Car> Cars => _appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => _appDbContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => _appDbContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
