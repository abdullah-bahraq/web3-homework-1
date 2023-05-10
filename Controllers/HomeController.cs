using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _1.Models;

namespace _1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ReverseName(string name)
    {
        if (name == null)
        {
            ViewBag.Message = "Please enter a valid name.";
        }
        else
        {
            string reversedName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];
            }

            ViewBag.Message = reversedName;
        }
        
        return View("Index");
    }
}

