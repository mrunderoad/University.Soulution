using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;

namespace University.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}