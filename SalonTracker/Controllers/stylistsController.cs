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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(stylists stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}