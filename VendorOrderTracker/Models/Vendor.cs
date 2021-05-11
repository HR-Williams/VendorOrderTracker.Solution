using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    // // public int Id { get; }
    public string Description { get; }
    public Vendor(string name)
    {
      Name = name;
    }
  }
}