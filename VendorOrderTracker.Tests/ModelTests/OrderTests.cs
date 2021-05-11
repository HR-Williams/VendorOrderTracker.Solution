using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass] 
  public class OrderTests
  {
    [TestMethod]
    public void OrderCustructor_CreatesInstanceOfOrder_Order()
    {
      Order NewOrder = new Order("test", "test description", 99);
      Assert.AreEqual(typeof(Order), NewOrder.GetType());
    }
    [TestMethod]
    public void
    GetTitle_ReturnsTitle_String()
    {
      string title = "CRI Regular";
      string description =
      "10 pastries";
      int price = 17;
      Order newOrder = new Order(title, description);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void
    GetDescription_ReturnsDescription_String()
    {
      string title = "CRI Regular";
      string description =
      "10 pastries";
      int price = 17;
      Order newOrder= new Order(title, description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void
    GetPrice_ReturnsPrice_Int()
    {
      string title = "CRI Regular";
      string description =
      "10 pastries";
      int price = 17;
      Order newOrder= new Order(title, description, price);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }
}