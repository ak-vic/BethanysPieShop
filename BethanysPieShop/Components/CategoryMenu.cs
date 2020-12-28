using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using System.Linq;

namespace BethanysPieShop.Components
{
    public class CategoryMenu: ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
