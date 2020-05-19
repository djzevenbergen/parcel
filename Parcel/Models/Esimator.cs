using System.Collections.Generic;

namespace Parcel.Models
{
  public class Estimator
  {
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Weight { get; set; }
    public double Cost { get; set; }
    public double Volume { get; set; }


    public Estimator(double height, double width, double depth, double weight)
    {
      Height = height;
      Width = width;
      Depth = depth;
      Weight = weight;
      Cost = 0;
      Volume = 0;

    }

    public void VolumeCalc()
    {
      Volume = Height * Depth * Width;
      Cost = EstCost(Volume, Weight);
    }

    public double EstCost(double Volume, double Weight)
    {
      return Volume + Weight;
    }
  }
}