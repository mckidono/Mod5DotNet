using Microsoft.AspNetCore.Mvc;
using System;

namespace Mod_5_Northwind.Controllers
{
    public class HomeController : Controller
    {
                public IActionResult Index() => View();
    }
}