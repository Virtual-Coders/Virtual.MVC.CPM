﻿using Microsoft.AspNetCore.Mvc;

namespace Virtual.MVC.CPM.MVC.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}
