using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SnakeEyesGame.Models;

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller
    {
        private SnakeEyes _snakeEyes;
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();
            //_snakeEyes wegschrijven in session variable
            HttpContext.Session.SetString("snake", JsonConvert.SerializeObject(_snakeEyes));
            return View(_snakeEyes);
        }

        public IActionResult Play()
        {
            //_snakeEyes uitlezen uit session variable
            _snakeEyes = JsonConvert.DeserializeObject<SnakeEyes>(HttpContext.Session.GetString("snake"));
            _snakeEyes.Play();
            //_snakeEyes wegschrijven in session variable
            HttpContext.Session.SetString("snake", JsonConvert.SerializeObject(_snakeEyes));
            return View("Index", _snakeEyes);
        }
    }
}