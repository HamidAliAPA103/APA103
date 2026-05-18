using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels.Products;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Utilities.Enums;
using _27_FrontToBackSqlConnection.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class ProductController : Controller
{
    private readonly AppDbContext _context;
    private readonly IWebHostEnvironment _env;

    public ProductController(AppDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public async Task<IActionResult> Index()
    {
        List<Product> products = await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Category)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();

        return View(products);
    }

    public async Task<IActionResult> Create()
    {
        await LoadCategoriesAsync();

        return View();
    }

    private Task LoadCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateVM productCreateVM)
    {
        await ValidateProductCreateAsync(productCreateVM);

        if (!ModelState.IsValid)
        {
            await LoadCategoriesAsync(productCreateVM.CategoryId);
            return View(productCreateVM);
        }

        Product product = new Product();

        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    private Task LoadCategoriesAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    private Task ValidateProductCreateAsync(ProductCreateVM productCreateVM)
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> Detail(int? id)
    {
        if (id is null || id < 1) return BadRequest();

        Product? product = await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Category)
            .Include(p => p.ProductImages)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product is null) return NotFound();

        return View(product);
    }
}
