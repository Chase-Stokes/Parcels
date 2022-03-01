using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcel")]

    public ActionResult Index()
    {
      List<Parcel> info = Parcel.GetAll();
      return View(info);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcel")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}