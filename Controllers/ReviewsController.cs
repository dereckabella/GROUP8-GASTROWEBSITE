using GastroWebsiteNew.Data;
using GastroWebsiteNew.Models;
using Microsoft.AspNetCore.Mvc;
using GastroWebsiteNew.Data;
using GastroWebsiteNew.Models;

public class ReviewsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReviewsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create(int placeId, string content, int rating)
    {
        var review = new Review
        {
            PlaceId = placeId,
            Content = content,
            Rating = rating
        };

        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();

        var place = await _context.Places.FindAsync(placeId);
        if (place.Type == "Restaurant")
        {
            return RedirectToAction("Details", "Places", new { id = placeId });
        }
        else if (place.Type == "Dish")
        {
            return RedirectToAction("Details", "Places", new { id = placeId });
        }

        return RedirectToAction("Index", "Places");
    }
}