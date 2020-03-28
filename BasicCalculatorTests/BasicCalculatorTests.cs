using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class BasicCalculatorTests
    {
        [TestMethod()]
        public void AddIntTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(4, 5);
            Assert.AreEqual(9, calc.Result);
        }

        [TestMethod()]

        public void AddDecimalTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(5.5M, 4.5M);
            Assert.AreEqual(10M, calc.Result);
        }

        [TestMethod()]

        public void AddIntArrayTest()
        {
            int[] testArr = { 1, 2, 3 };
            BasicCalculator calc = new BasicCalculator();
            calc.Add(testArr);
            Assert.AreEqual(6, calc.Result);
        }

        [TestMethod()]

        public void AddDecimalArrayTest()
        {
            decimal[] testArr = { 1.5M, 2.5M, 3.5M };
            BasicCalculator calc = new BasicCalculator();
            calc.Add(testArr);
            Assert.AreEqual(7.5M, calc.Result);
        }

        [TestMethod()]

        public void SubtractIntTest()
        {
            
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(10,5);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void SubtractDecimalTest()
        {

            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(10.5M, 5.5M);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void SubtractIntArrayTest()
        {
            int[] test = { 5, 1, 2 };
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(test);
            Assert.AreEqual(2, calc.Result);
        }

        [TestMethod()]

        public void SubtractDecimalArrayTest()
        {
            decimal[] test = { 10M, 2.5M, 1M };
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(test);
            Assert.AreEqual(6.5M, calc.Result);
        }



        [TestMethod()]

        public void DivideIntTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Divide(10,2);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void DivideDecimalTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Divide(10.5M, 2M);
            Assert.AreEqual(5.25M, calc.Result);
        }

        [TestMethod()]

        public void DivideIntArrayTest()
        {
            int[] test = { 20, 5, 2 };
            BasicCalculator calc = new BasicCalculator();
            calc.Divide(test);
            Assert.AreEqual(2, calc.Result);
        }


        [TestMethod()]

        public void DivideDecimalArrayTest()
        {
            decimal[] test = { 40.8M, 5M, 2M };
            BasicCalculator calc = new BasicCalculator();
            calc.Divide(test);
            Assert.AreEqual(4.08M, calc.Result);
        }

        [TestMethod()]

        public void MultiplyIntTest()
        {
           
            BasicCalculator calc = new BasicCalculator();
            calc.Multiplication(10, 3);
            Assert.AreEqual(30, calc.Result);
        }

        [TestMethod()]

        public void MultiplyDecimalTest()
        {

            BasicCalculator calc = new BasicCalculator();
            calc.Multiplication(5.5M, 2.5M);
            Assert.AreEqual(13.75M, calc.Result);
        }

        [TestMethod()]

        public void MultiplyIntArrayTest()
        {
            int[] test = { 5, 2, 3 };
            BasicCalculator calc = new BasicCalculator();
            calc.Multiplication(test);
            Assert.AreEqual(30, calc.Result);
        }

        [TestMethod()]

        public void MultiplyDecimalArrayTest()
        {
            decimal[] test = { 2.5M, 7.5M, 5M };
            BasicCalculator calc = new BasicCalculator();
            calc.Multiplication(test);
            Assert.AreEqual(93.75M, calc.Result);
        }

        [TestMethod()]

        public void PowerIntTest()
        {
           
            BasicCalculator calc = new BasicCalculator();
            calc.Exponentiation(5, 2);
            Assert.AreEqual(25, calc.Result);
        }

        [TestMethod()]

        public void PowerDecimalTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Exponentiation(7.5M, 2M);
            Assert.AreEqual(56.25M, calc.Result);
        }

        [TestMethod()]

        public void RadicalIntTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Radical(25, 2);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void RadicalDecimalTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Radical(5.8M, 2M);
            Assert.AreEqual(2.40831891575846M, calc.Result);
        }
    }
}