using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPong;

namespace PingPong.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/display")]
    public ActionResult DisplayResult()
    {
      PingPong newPingPong = new PingPong();
      List<string> allNumbers = newPingPong.GetResult(int.Parse(Request.Form["inputNumber"]));
      return View(allNumbers);

    }
  }
}
