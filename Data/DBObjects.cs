using Saite_1.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Saite_1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Car.Any())
            {
                content.AttachRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и тихий автомобил кампании Tesla",
                        img = "/img/tesla.jpg",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/fiesta.png",
                        price = 4500,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMV M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw_m3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C Class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/mercedes_c.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экологичный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan_ev.jpg",
                        price = 14000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                  );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get 
            {
                if(category == null)
                {
                    var list = new Category[]
                        {
                            new Category {categoryName = "Электромобили", desc="Современный вид транспорта"},
                            new Category { categoryName="Футурестические машины", desc="На реативной тяге"},
                            new Category { categoryName="Классические автомобили", desc="Машины с двигательем внутреньенго сгорания"}
                        };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName,el);
                }

                return category;
            }
        }
    }
}
