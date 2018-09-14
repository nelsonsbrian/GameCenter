using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace ClockAngle.Controllers
{
    public class ClockAnglesController : Controller
    {
      [HttpGet("/clockangle")]
      public ActionResult LP()
      {
        return View("clockangle");
      }
    }
}
