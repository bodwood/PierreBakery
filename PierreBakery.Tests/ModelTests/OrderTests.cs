using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBarkery.Models;
using System;

namespace PierreBarkery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("order test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderDescription = "donuts";
      Order newOrder = new Order(orderDescription);
      Assert.AreEqual(orderDescription, newOrder.Description);
    }

    [TestMethod]
    public void SetOrderDescription_SetsOrderDescription_String()
    {
      string orderDescription = "donuts";
      Order newOrder = new Order(orderDescription);

      string setDescription = "croissants";
      newOrder.Description = setDescription;
      Assert.AreEqual(setDescription, newOrder.Description);
    }

    [TestMethod]
    public void GetAllOrders_ResturnsEmptyOrderList_OrderList()
    {
      List<Order> newList = new List<Order>{};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsListOfOrders_OrderList()
    {
      string orderDescription1 = "donuts";
      string orderDescription2 = "croissants";
      Order newOrder1 = new Order(orderDescription1);
      Order newOrder2 = new Order(orderDescription2);
      List<Order> newList = new List<Order>{newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
