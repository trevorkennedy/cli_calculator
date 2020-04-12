using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
  [TestClass]
  public class Test_Calculator
  {
    [TestMethod]
    public void Test_Addition()
    {
      double lhs = 3.1;
      double rhs = 2.9;
      Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
      double result = addition.Perform_binary_calculation(lhs, rhs);
      Assert.AreEqual(6.0, result);
    }

    [TestMethod]
    public void Test_Divide()
    {
      Assert.Fail();
    }
  }
}
