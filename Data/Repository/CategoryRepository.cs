using Saite_1.Data.interfaces;
using Saite_1.Data.Models;
using System.Collections.Generic;

namespace Saite_1.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent _appDbContent;
        public CategoryRepository(AppDBContent appDbContent)
        {
            this._appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => _appDbContent.Categories;
    }
}
