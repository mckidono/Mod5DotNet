using Microsoft.AspNetCore.Mvc;
using System;

namespace Mod_5_Northwind.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Category() => View();
    }
}