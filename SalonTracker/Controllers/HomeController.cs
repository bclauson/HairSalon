
using Microsoft.AspNetCore.Mvc;

namespace SalonTracker.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}