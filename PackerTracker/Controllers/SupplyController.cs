using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System;

namespace PackerTracker.Controllers
{
  public class SupplyController : Controller
  {
    [HttpGet("/supply")]
    public ActionResult Index()
    {

      List<Supply> allSupplies = Supply.SupplyList;
      return View(allSupplies);
    }

    [HttpGet("/supply/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/supply")]
    public ActionResult Create(string name, bool packed, int weight, bool needToBuy)
    {
      Supply newSupply = new Supply(name, packed, weight, needToBuy);
      return RedirectToAction("Index");
    }

    [HttpPost("/supply/{id}/delete")]
    public ActionResult Destroy(int id)
    {
      Supply.RemoveSupply(id);
      return RedirectToAction("Index");
    }

  }
}
