using SalonTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SalonTracker.Controllers
{
  public class StylistsController : Controller
  {
    private readonly SalonTrackerContext _db;

    public StylistsController(SalonTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<stylists> model = _db.Stylists.ToList();
      return View(model);
    }
  }
}