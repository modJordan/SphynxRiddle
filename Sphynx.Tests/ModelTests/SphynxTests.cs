// using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sphynx.Models;
using System.Collections.Generic;
using System;

namespace Sphynx.Tests
{
  [TestClass]
  public class SphynxTests
  {
    // public void Dispose()
    // {
    //   SphynxTests.ClearAll();
    // }

    [TestMethod]
    public void RiddleConstructor_CreatesInstanceOfRiddle()
    {
      Riddle1 newRiddle = new Riddle1("What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?");
      Assert.AreEqual(typeof(newRiddle));
    }


  }
}