using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; }
    
    public string Description { get; }

    public int Price { get; }

    public DateTime Date { get; }
    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Today;
    }
  }
}