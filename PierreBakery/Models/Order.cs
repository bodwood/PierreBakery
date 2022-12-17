using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierreBarkery.Models
{
  public class Order
  {
    public string Description { get; set; }
     public string Amount { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description, string orderAmount, string orderPrice, string orderDate)
    {
      Description = description;
      Amount = orderAmount;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int id)
    {
      return _instances[id - 1];
    }

  }
}