

using System.Linq;

namespace Saite_1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any()) 
            {
                content.Categories.AddRange(Categories.Select);
            }
        }
    }
}
