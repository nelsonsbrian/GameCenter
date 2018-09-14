using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace LeapYear.Controllers
{
    public class LeapYearsController : Controller
    {
      [HttpGet("/leapyear")]
      public ActionResult LP()
      {
        return View("LeapYear");
      }
    }
}
