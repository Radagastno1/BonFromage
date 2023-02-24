using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BonFromage.Models;
using Microsoft.AspNetCore.Html;
using System.Globalization;

namespace BonFromage.Controllers;

[Route("booking")]
public class BookingController : Controller
{
    MyDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public BookingController(ILogger<HomeController> logger, MyDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MakeBooking(Booking booking)
    {
        _context.Bookings.AddAsync(booking);
        _context.SaveChangesAsync();
        return View("makebooking", booking);
    }
}
