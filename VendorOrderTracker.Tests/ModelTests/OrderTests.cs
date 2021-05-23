using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass] 
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderCustructor_CreatesInstanceOfOrder_Order()
    {
      Order NewOrder = new Order("test", "test description", 99, DateTime.Today);
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
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
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
      DateTime date = DateTime.Today;
      Order newOrder= new Order(title, description, price, date);
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
      DateTime date = DateTime.Today;
      Order newOrder= new Order(title, description, price,date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void
    GetDate_ReturnsDate_Date()
    {
      string title = "CRI Regular";
      string description =
      "10 pastries";
      int price = 17;
      DateTime date = DateTime.Today;
      Order newOrder= new Order(title, description, price, date);
      DateTime result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "CRI Regular";
      string description =
      "10 pastries";
      int price = 17;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      string updatedTitle = "CRI Standing Order";
      newOrder.Title= updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "CRI Regular";
      string title02 = "Standing Order";
      string description01 = "10 pastries";
      string description02 = "8 pastries";
      int price01 = 17;
      int price02 = 14;
      DateTime date01 = DateTime.Today;
      DateTime date02 = DateTime.Today;
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result); 
    }
  }
}