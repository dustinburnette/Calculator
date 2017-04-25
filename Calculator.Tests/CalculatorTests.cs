using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_Should_Add_Two_Numbers_And_Return_The_Sum()
        {
            int result = Calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Subtract_Should_Minus_Two_Numbers_Return_Difference()
        {
            int result = Calculator.Subtract(12, 6);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void Divide_Should_Divide_Two_Numbers()
        {
            int result = Calculator.Divide(30,3);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void Multiply_Should_Multiply_Two_Numbers()
        {
            int result = Calculator.Multiply(13,4);
            Assert.AreEqual(52, result);
        }
        [TestMethod]
        public void Module_Should_Return_Remainder()
        {
            int result = Calculator.Modules(10,5);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ThisIsANewTest()
        {
            string result = Calculator.Test("Hello");
            Assert.AreEqual("Hello", result);
        }
    }
}
