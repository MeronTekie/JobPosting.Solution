using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;
using System.Collections.Generic;

namespace JobPosting.Controllers
{
  public class JobController : Controller
  {
    [HttpGet("/job")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/job/new")]
    public ActionResult CreatePost()
    {
      return View();
    }

    [HttpPost("/job")]
    public ActionResult Create(string title, string description, string location, int salary)
    {
      Job newPosting = new Job(title, description, location, salary);
      return RedirectToAction("Index");
    }
  }
}
