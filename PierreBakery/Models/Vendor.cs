using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierreBarkery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }  
    public int Id { get; } 
      public string Location { get; set; } 
    public List<Order> Orders { get; set; } 

    public Vendor(string vendorName, string vendorLocation)
    {
      Name = vendorName;
      Location = vendorLocation;
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

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }

}