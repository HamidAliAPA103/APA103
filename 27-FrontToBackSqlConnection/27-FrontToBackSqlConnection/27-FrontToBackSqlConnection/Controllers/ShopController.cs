using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details(int? id)
        {

            if (id is null || id < 1)
            {
                return BadRequest();
            }

            Product product = _context.Products
                .Where(p=>!p.IsDelete)
                .Include(p=>p.ProductImages)
                .Include(p=>p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (product is null) return NotFound();

            DetailsVM detailVM = new()
            {
                Product = product
            };
              



            return View(detailVM);




        }
    }
}
