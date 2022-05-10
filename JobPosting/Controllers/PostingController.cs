using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobPosting.Models;

namespace JobPosting.Controllers
{
  public class JobPostingController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreatePost()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string location, int salary)
    {
      Job newPosting = new Job(title, description, location, salary);
      return RedirectToAction("Index");
    }
  }
}
