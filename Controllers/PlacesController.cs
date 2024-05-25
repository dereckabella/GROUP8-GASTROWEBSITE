using GastroWebsiteNew.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GastroWebsiteNew.Data;
using GastroWebsiteNew.Models;

public class PlacesController : Controller
{
    private readonly ApplicationDbContext _context;

    public PlacesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Places.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var place = await _context.Places
            .Include(p => p.Reviews)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (place == null)
        {
            return NotFound();
        }

        return View(place);
    }

 
}