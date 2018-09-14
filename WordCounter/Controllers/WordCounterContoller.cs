using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCountersController : Controller
    {
      [HttpGet("/words")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/words")]
      public ActionResult Words()
      {
        RepeatCounter.MasterString = Request.Form["new-master"];
        return View("words");
      }

      [HttpPost("/words/add")]
      public ActionResult Words()
      {
        RepeatCounter.MasterString = Request.Form["new-word"];
        return View("words");
      }

    }
}
