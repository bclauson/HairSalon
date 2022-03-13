using SalonTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SalonTracker.Controllers
{
  public class clientsController : Controller
  {
    private readonly SalonTrackerContext _db;

    public clientsController(SalonTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<clients> model = _db.Clients.ToList();
      return View(model);
    }

    
    public ActionResult Create()
    {
      ViewBag.stylistId = new SelectList(_db.Stylists, "stylistsId", "stylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(clients client)
    {

      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "stylists");
    }

    public ActionResult Details(int id)
    {
      clients thisclient = _db.Clients.FirstOrDefault(clients => clients.clientsId == id);
      return View(thisclient);
    }




  }
}
