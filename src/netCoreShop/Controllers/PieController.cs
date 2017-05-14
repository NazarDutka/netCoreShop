using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netCoreShop.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace netCoreShop.Controllers
{
    public class PieController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;
        public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }
        public ViewResult List()
        {
            return View(_pieRepository.Pies);
        }
    }
}
