using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace Palindrome.Controllers
{
    public class PalindromesController : Controller
    {
      [HttpGet("/palindrome")]
      public ActionResult LP()
      {
        return View("Palindrome");
      }
    }
}
