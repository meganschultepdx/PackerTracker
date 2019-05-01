using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Supply
  {
    public string Name { get; set;}
    public bool Packed { get; set;}
    public int Weight { get; set;}
    public bool NeedToBuy { get; set;}
    public static List<Supply> SupplyList {get; set;} = new List<Supply> {};
    public int Id { get; set;}

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
      int TotalWeight = 0;
      foreach (Supply supply in SupplyList)
      {
        if (this.Weight > 0)
        {
          TotalWeight += this.Weight;
        }
      }
      return TotalWeight;
    }

    public static void RemoveSupply(int id)
    {
      SupplyList.Remove(SupplyList[id - 1]);
    }

    public static void ClearAll()
    {
      SupplyList.Clear();
    }

  }
}
