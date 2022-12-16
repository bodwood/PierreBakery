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

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string vendorName = "vendor name";
      Vendor newVendor = new Vendor(vendorName);
      Assert.AreEqual(vendorName, newVendor.Name);
    }

    [TestMethod]
    public void SetName_SetsName_String()
    {
      string vendorName = "vendor name";
      Vendor newVendor = new Vendor(vendorName);
      string updatedName = "updated vendor name";
      newVendor.Name = updatedName;
      Assert.AreEqual(updatedName, newVendor.Name);
    }
  }
}
