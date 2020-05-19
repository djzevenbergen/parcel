using System.Collections.Generic;

namespace Parcel.Models
{
  public class Parcel
  {
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> { };

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public Item(string des)
    {
      Description = des;
      _instances.Add(this);
    }
    public Item(string des, int priority)
      : this(des)
    {
      Priority = priority;
    }
  }
}