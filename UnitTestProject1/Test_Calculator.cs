using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calulator_Tests
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
            Logic_Interfaces.IBinaryOperation addition = new Logic.Division();
            double result = addition.Perform_binary_calculation(3.0, 2.0);
            Assert.AreEqual(1.5, result);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            Logic_Interfaces.IBinaryOperation addition = new Logic.Subtraction();
            double result = addition.Perform_binary_calculation(3.0, 2.0);
            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            Logic_Interfaces.IBinaryOperation addition = new Logic.Multiplication();
            double result = addition.Perform_binary_calculation(3.0, 2.0);
            Assert.AreEqual(6.0, result);
        }

        [TestMethod]
        public void Test_Reciprocal()
        {
            Logic_Interfaces.IBinaryOperation addition = new Logic.Reciprocal();
            double result = addition.Perform_binary_calculation(10.0, 2.0);
            Assert.AreEqual(0.1, result);
        }

        [TestMethod]
        public void Test_Square_Root()
        {
            Logic_Interfaces.IBinaryOperation addition = new Logic.Square_Root();
            double result = addition.Perform_binary_calculation(4.0, 100.0);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void Test_Initialization()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            Assert.AreEqual("0", calculator.Equals());
        }

        [TestMethod]
        public void Test_Addition_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(99.5);
            calculator.Addition_entered();
            Assert.AreEqual("99.5", calculator.Equals());
        }

        [TestMethod]
        public void Test_Subtraction_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(99.5);
            calculator.Subtraction_entered();
            calculator.Number_entered(1.0);
            Assert.AreEqual("98.5", calculator.Equals());
        }

        [TestMethod]
        public void Test_Multiplication_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(30.0);
            calculator.Multiplication_entered();
            calculator.Number_entered(2.0);
            Assert.AreEqual("60", calculator.Equals());
        }

        [TestMethod]
        public void Test_Division_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(30.0);
            calculator.Division_entered();
            calculator.Number_entered(2.0);
            Assert.AreEqual("15", calculator.Equals());
        }

        [TestMethod]
        public void Test_Reciprocal_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(-4.0);
            calculator.Reciprocal_entered();
            Assert.AreEqual("-0.25", calculator.Equals());
        }

        [TestMethod]
        public void Test_Square_Root_Calc()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            calculator.Number_entered(9.0);
            calculator.Square_root_entered();
            calculator.Number_entered(2.0);
            Assert.AreEqual("3", calculator.Equals());
        }

        [TestMethod]
        public void Test_Example()
        {
            Logic.Calculator calculator = new Logic.Calculator();
            string result = calculator.Number_entered(51.6);
            result = calculator.Addition_entered();
            Assert.AreEqual("51.6", result);
            result = calculator.Number_entered(25.1);
            Assert.AreEqual("25.1", result);
            Assert.AreEqual("76.7", calculator.Equals());
            Assert.AreEqual("76.7", calculator.Equals());
        }
    }
}
