using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BonFromage.Models;
using Microsoft.AspNetCore.Html;

namespace BonFromage.Controllers;
  [Route("menu")]
public class MenuController : Controller
{
    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

     [HttpGet]
    public ActionResult Index()
    {
        List<Dish>Dishes = new(){new Dish("Coq au Vin ","En gryta med kyckling tillagad med rött vin, champinjoner och bacon.", 179), new Dish("Bouillabaisse ","En fisk- och skaldjursgryta med tomat, fänkål, vitlök och saffran.", 125), new Dish("Ratatouille","En grönsaksgryta med aubergine, zucchini, paprika, tomater och lök.", 119)};
        return View(Dishes);
    }
}
