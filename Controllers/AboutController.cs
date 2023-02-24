

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BonFromage.Models;
using Microsoft.AspNetCore.Html;

namespace BonFromage.Controllers;
 [Route("about")]
public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }
       [HttpGet]
    public ActionResult Index()
    {
        List<Adventage>adventages = new();
        adventages.Add(new Adventage("Autentisk fransk matlagning", "Vi använder endast de finaste franska ingredienserna för att skapa autentiska franska rätter som är smakrika och välsmakande."));
        adventages.Add(new Adventage("Hållbarhet och miljömedvetenhet", "Vi på Bon Fromage tror på att ta hand om vår planet och använder hållbara och miljövänliga råvaror när det är möjligt. Vi arbetar för att minska vår klimatpåverkan och hoppas kunna bidra till en bättre miljö för framtida generationer."));
        adventages.Add(new Adventage("Vegetarisk och vegansk matlagning", " Vi har ett brett utbud av vegetariska och veganska alternativ på vår meny som alla är lika läckra och färgstarka som våra kötträtter. Vi tror att det är viktigt att erbjuda alternativ för alla smaker och dieter."));
        adventages.Add(new Adventage("Stämning och atmosfär", "Vi har skapat en mysig och inbjudande atmosfär på vår restaurang, perfekt för en romantisk middag eller en avslappnad lunch med vänner. Vi vill att våra gäster ska känna sig hemma och bekväma hos oss."));
        return View(adventages);
    }

}
