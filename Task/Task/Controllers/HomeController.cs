using DateAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.ViewModels;

namespace Task.Controllers;

public class HomeController : Controller
{
    private AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        HomeViewModel homeVM = new()
        {
            SlideItems=_context.SlideItems.AsNoTracking(),
            ShippingItem2s=_context.ShippingItems2.AsNoTracking()
        };
        return View (homeVM);
    }
}
