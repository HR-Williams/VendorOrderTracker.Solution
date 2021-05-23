using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
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

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsAllVendorObjects_VendorList()
    // {
    //   string name01 = "Suzie's Cafe";
    //   string name02 = "Coffee Research Institute";
    //   string description01 = "cafe local ";
    //   string description02 = "weird coffee shop";
    //   Vendor newVendor1 = new Vendor(name01, description01);
    //   Vendor newVendor2 = new Vendor(name02, description02);
    //   List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    //   List<Vendor> result = Vendor.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorsList()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "Coffee Research Institute";
      string description01 = "local cafe";
      string description02 = "weird coffee shop";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      
      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "Coffee Research Institute";
      string description01 = "local cafe";
      string description02 = "weird coffee shop";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

      // [TestMethod]
      // public void AddOrder_AssociatesOrderWithVendor_OrderList()
      // {
      //   string title = "CRI Regular";
      //   string description = "10 pastries";
      //   int price = 17;
      //   DateTime date = DateTime.Today;
      //   Order newOrder= new Order(title, description, price, date);
      //   List<Order> newList = new List<Order> { newOrder };
      //   string name = "Coffee Research Institute";
      //   Vendor newVendor = new Vendor(name, description);
      //   newVendor.AddOrder(newOrder);
      //   List<Order> result = newVendor.Orders;
      //   CollectionAssert.AreEqual(newList, result); 
      // }
  }
  }
