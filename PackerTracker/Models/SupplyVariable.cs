using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Models {

  public class Supply
  {
    public string Name { get; set;}
    public bool Packed { get; set;}
    public int Weight { get; set;}
    public bool NeedToBuy { get; set;}
    public static List<Supply> SupplyList {get; set;} = new List<Supply> {};
    public int ID { get; set;}

    public Supply(string name, bool packed, int weight, bool needToBuy)
    {
      Name = name;
      Packed = packed;
      Weight = weight;
      NeedToBuy = needToBuy;
      SupplyList.Add(this);
      Id = SupplyList.Count;
    }

    public int TotalWeight ()
    {
      foreach (Supply supply in SupplyList)
      {
        if (weight > 0)
        {
          return += weight;
        }
      }
    }

    public static void ClearAll()
    {
      CarsList.Clear();
    }

  }
