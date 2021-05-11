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
      Order NewOrder = new Order();
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
  }
}