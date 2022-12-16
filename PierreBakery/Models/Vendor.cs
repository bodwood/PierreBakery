using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierreBarkery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string name {get; set;}  //name of vendor
    public int Id {get;}  //unique id of vendor
    public List<Order> Orders {get; set;} //list of orders (i.e. Matts BBQ -> Pulled Pork)
  }
}