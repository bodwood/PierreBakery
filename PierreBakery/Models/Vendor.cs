using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierreBarkery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }  //name of vendor
    public int Id { get; }  //unique id of vendor
    public List<Order> Orders { get; set; } //list of orders (i.e. Matts BBQ -> Pulled Pork)

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int id)
    {
      return _instances[id-1];
    }
  }

}