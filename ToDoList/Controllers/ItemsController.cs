using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Parcel> allItems = Parcel.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(int sidex, int sidey, int sidez, int weight)
    {
      Parcel myItem = new Parcel(sidex, sidey, sidez, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Parcel.ClearAll();
      return View();
    }

  }
}