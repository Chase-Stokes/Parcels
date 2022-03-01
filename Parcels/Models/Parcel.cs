using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public int Weight {get; set;}

    public static List<Parcel> _parcelInfo = new List<Parcel>{};

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      _parcelInfo.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _parcelInfo;
    }

    public int Volume()
    {
      return (Length * Width * Height);
    }
    public double CostToShip()
    {
      // int volume2 = Parcel.Volume();
      return (Weight * .5);
    }
  }
}