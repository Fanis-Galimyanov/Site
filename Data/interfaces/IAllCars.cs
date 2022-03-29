﻿using Saite_1.Data.Models;
using System.Collections.Generic;

namespace Saite_1.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get;}
        Car getObjectCar(int carId);
    }
}
