using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser< userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.treats = _db.Treats.ToList();
      ViewBag.flavors = _db.Flavors.ToList();
    return View();
    }
  }
}