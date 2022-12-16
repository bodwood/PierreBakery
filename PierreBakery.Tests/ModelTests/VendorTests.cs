using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBarkery.Models;
using System;

namespace PierreBarkery.Tests
{
  [TestClass]
   public class VendorTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendor test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}
