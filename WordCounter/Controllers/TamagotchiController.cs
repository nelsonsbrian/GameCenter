using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace Tamagotchi.Controllers
{
    public class TamagotchisController : Controller
    {
      [HttpGet("/tamagotchi")]
      public ActionResult LP()
      {
        return View("tamagotchi");
      }
    }
}
