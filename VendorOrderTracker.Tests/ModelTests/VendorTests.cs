using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test descrip");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      string description = "cafe";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Suzie's Cafe";
      string description = "cafe local";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
  }
