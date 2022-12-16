using Microsoft.AspNetCore.Mvc;

namespace PierreBarkery.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View();
    }
  }
}