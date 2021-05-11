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
      Order NewOrder = new Order("test");
      Assert.AreEqual(typeof(Order), NewOrder.GetType());
    }
    [TestMethod]
    public void
    GetTitle_ReturnsTitle_String()
    {
      string title = "CRI Regular";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void
    GetDescription_ReturnsDescription_String()
    {
      string description =
      "10 pastries";
      Order newOrder= new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}