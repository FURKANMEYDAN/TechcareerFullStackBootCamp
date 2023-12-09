using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bootcamp.Models;

namespace bootcamp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Bootcamp();
        kurs.Id=1;
        kurs.Title="fullstack";
        kurs.Image="1.jpg";
        kurs.Description="Blaghblah";
        return View(kurs);
    }
}
