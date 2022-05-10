using System.Collections.Generic;

namespace JobPosting.Models
{
  public class Job
  {
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public string JobLocation { get; set; }
    public int JobSalary { get; set; }
    private static List<Job> _instances = new List<Job> { };
    
    public Job(string jobTitle, string jobDescription, string jobLocation, int jobSalary)
    {
      JobTitle = jobTitle;
      JobDescription = jobDescription;
      JobLocation = jobLocation;
      JobSalary = jobSalary;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}