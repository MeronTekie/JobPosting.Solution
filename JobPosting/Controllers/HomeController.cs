using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;
using System.Collections.Generic;

namespace JobPosting.Controllers
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