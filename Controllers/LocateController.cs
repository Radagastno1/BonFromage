 using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BonFromage.Models;
using Microsoft.AspNetCore.Html;

namespace BonFromage.Controllers;
     [Route("locate")]
public class LocateController : Controller
{
    private readonly ILogger<LocateController> _logger;

    public LocateController(ILogger<LocateController> logger)
    {
        _logger = logger;
    }

     [HttpGet]
    public ActionResult Index()
    {
      string mapHTML = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2131.363714378298!2d12.962078115406433!3d57.71027934680036!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x465aa09f786c658b%3A0xbad42e36a0e880f9!2sHagtornsliden%2012%2C%20507%2061%20Bor%C3%A5s!5e0!3m2!1sen!2sse!4v1677077599045!5m2!1sen!2sse\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>";
        return View(new HtmlString(mapHTML));
    }
}

