using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
namespace Portfolio.Controllers     
{
    public class HomeController : Controller   
    {
        
        public static List<string> FoodNames = new List<string>()
        {
            "Apple Pie",
            "Burrito",
            "Clams Casino",
            "Donuts"
        };
        public static List<Project> Projects = new List<Project>()
        {
            new Project("https://vignette.wikia.nocookie.net/sonicpokemon/images/0/01/152_chikorita_by_pklucario.png/revision/latest?cb=20130617041510","Project1","lorem ipsum"),
            new Project("","Project2","lorem ipsum"),
            new Project("","Project3","lorem ipsum"),
            new Project("https://vignette.wikia.nocookie.net/sonicpokemon/images/0/01/152_chikorita_by_pklucario.png/revision/latest?cb=20130617041510","Project4","lorem ipsum"),
            new Project("https://vignette.wikia.nocookie.net/sonicpokemon/images/0/01/152_chikorita_by_pklucario.png/revision/latest?cb=20130617041510","Project5","lorem ipsum"),
            new Project("https://vignette.wikia.nocookie.net/sonicpokemon/images/0/01/152_chikorita_by_pklucario.png/revision/latest?cb=20130617041510","Project6","lorem ipsum")
        };


        [HttpGet("")]     
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/project")]     
        public IActionResult Project()
        {
            ViewBag.Projects = Projects;
            return View("Project");
        }
        [HttpPost("upload")]
        // public IActionResult Upload(List<Project>)
        // {
        //     FoodNames.Add(name);
        //     return Redirect("/razor");
        // }
        [HttpGet("/contact")]  
        public IActionResult Contact()
        {
            return View("Contact");
        }
        [HttpPost("send")]
        public IActionResult Send()
        {
            return Redirect("/");
        }

        [HttpGet("/razor")]
        public IActionResult Razor()
        {
            ViewBag.FoodNames = FoodNames;
            return View("Razorfun");
        }

        [HttpPost("process")]
        public IActionResult Process(string name)
        {
            FoodNames.Add(name);
            return Redirect("/razor");
        }
    }
}