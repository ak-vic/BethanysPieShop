using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
