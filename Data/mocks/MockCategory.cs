using Saite_1.Data.interfaces;
using Saite_1.Data.Models;
using System.Collections.Generic;

namespace Saite_1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get 
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc="Современный вид транспорта"},
                    new Category { categoryName="Футурестические машины", desc="На реативной тяге"},
                    new Category { categoryName="Классические автомобили", desc="Машины с двигательем внутреньенго сгорания"}
                };
            }
        }
    }
}
