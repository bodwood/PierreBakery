using Microsoft.AspNetCore.Mvc;

namespace PierreBarkery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}