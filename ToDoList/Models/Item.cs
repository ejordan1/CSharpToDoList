using System.Collections.Generic;

namespace ToDoList.Models
{
//   public class Item
//   {
//     public string Description { get; set; }
//     private static List<Item> _instances = new List<Item> {};

//     public Item (string description)
//     {
//       Description = description;
//       _instances.Add(this);
//     }

//     public static List<Item> GetAll()
//     {
//       return _instances;
//     }

//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }

//   }

    public class Parcel
  {
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }

    private static List<Parcel> _Packages = new List<Parcel> {};

    public Parcel (int sidex, int sidey, int sidez, int weight)
    {
      Volume = sidex * sidey * sidez;
      Weight = weight;
      Cost = (Volume + Weight / 2) + 12; 
      _Packages.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _Packages;
    }

    public static void ClearAll()
    {
      _Packages.Clear();
    }

  }
}