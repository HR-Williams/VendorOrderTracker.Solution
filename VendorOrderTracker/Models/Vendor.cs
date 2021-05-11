using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    // // public int Id { get; }
    public string Description { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }    
  }
}