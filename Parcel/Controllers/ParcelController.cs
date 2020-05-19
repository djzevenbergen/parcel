using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcels/estimate")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Estimate(double height, double width, double depth, double weight)
    {
      Parcel myParcel = new Parcel(height, width, depth, weight);
      return RedirectToAction("Index");
    }

  }
}