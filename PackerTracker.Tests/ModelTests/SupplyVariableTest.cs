using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace SupplyTracker.Tests
{
  [TestClass]
  public class SuppliesVariableTest : IDisposable
  {
    public void Dispose()
    {
      Supply.ClearAll();
    }

    [TestMethod]
    public void TotalWeight_AddTotalWeightOfSupplies_Int()
    {
      //Arrange

      Supply newSupply= new Supply("backpack", true, 5, false);

      //Act
      int result = newSupply.TotalWeight;

      //Assert
      Assert.AreEqual(5, result);
    }

  }
}
