using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels/estimate")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Estimate(double height, double width, double depth, double weight)
    {
      Estimator myParcel = new Estimator(height, width, depth, weight);
      myParcel.VolumeCalc();
      return View("Index", myParcel);
    }

    [HttpGet("/index")]
    public ActionResult Index()
    {
      Estimator testParcel = new Estimator(0, 0, 0, 0);
      return View(testParcel);
    }
  }
}