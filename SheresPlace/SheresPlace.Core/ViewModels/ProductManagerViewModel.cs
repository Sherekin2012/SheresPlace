using SheresPlace.Core.Models;
using System.Collections.Generic;

namespace SheresPlace.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
