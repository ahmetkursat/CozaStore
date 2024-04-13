using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;

namespace ECommerceApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
