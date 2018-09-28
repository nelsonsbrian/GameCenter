using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      // public ActionResult Index()
      // {
      //   return new EmptyResult();
      // }

      // public ActionResult Index()
      // {
      //   string test = "tissue";
      //   List<RepeatCounter> newList = new List<RepeatCounter> {};
      //   RepeatCounter newWord = new RepeatCounter(test);
      //   RepeatCounter.MasterString = "tissue";
      //   newList.Add(newWord);
      //   return View(newList);
      }
    }

}
