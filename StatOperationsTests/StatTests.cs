using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using SamplingOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatTests
    {
        [TestMethod()]
        public void intMeanTest()
        {
            int[] nums = { 1, 2, 3 };
            Assert.AreEqual(2, Mean.findMean(nums));
        }

        [TestMethod()]
        public void decimalMeanTest()
        {
            decimal[] nums = { 3.3M, 6.6M, 9.9M };
            Assert.AreEqual(6.6M, Mean.findMean(nums));
        }

        [TestMethod()]
        public void intMedianTest()
        {
            int[] nums = { 1, 5, 4, 2, 3 };
            Assert.AreEqual(3, Median.findMedian(nums));
        }

        [TestMethod()]
        public void decimalMedianTest()
        {
            decimal[] nums = { 3.3M, 9.9M, 13.2M, 6.6M };
            Assert.AreEqual(8.25M, Median.findMedian(nums));
        }

        [TestMethod()]
        public void intModeTest()
        {
            int[] nums = { 1, 2, 2, 3, 3, 3, 4 };
            foreach (int num in Mode.findMode(nums))
            {
                Assert.AreEqual(3, num);
            }
        }

        [TestMethod()]
        public void decimalModeTest()
        {
            decimal[] nums = { 1.2M, 1.2M, 6.7M, 8.9M, 4.5M, 4.5M, 4.5M };
            foreach (decimal num in Mode.findMode(nums))
            {
                Assert.AreEqual(4.5M, num);
            }
        }

        [TestMethod()]
        public void intVarianceTest()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(2, Variance.findVariance(nums));
        }

        [TestMethod()]
        public void decimalVarianceTest()
        {
            decimal[] nums = { 3.3M, 6.6M, 9.9M, 13.2M };
            Assert.AreEqual(13.6125M, Variance.findVariance(nums));
        }

        [TestMethod()]
        public void intSDTest()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(1.4142136M, StandardDeviation.findSD(nums));
        }

        [TestMethod()]
        public void decimalSDTest()
        {
            decimal[] nums = { 3.3M, 6.6M, 9.9M, 13.2M };
            Assert.AreEqual(3.6895122M, StandardDeviation.findSD(nums));
        }

        [TestMethod()]
        public void intQuartilesTest() // array larger than size of 1 and evens + decimals
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            decimal[] ans = { 3, 6, 9 };
            CollectionAssert.AreEqual(ans, Quartiles.findQuartiles(nums));
        }

        [TestMethod()]
        public void intSkewTest()
        {
            int[] nums = { 1, 2, 3, 4, 100, 400, 400, 600, 700 };
            Assert.AreEqual("Negative Skewness", Skewness.findSkew(nums));
        }

        [TestMethod()]
        public void decimalSkewTest()
        {
            decimal[] nums = { 1, 1.7M, 1.8M, 1.9M, 2.1M, 4M, 6M, 8M };
            Assert.AreEqual("Likely a Positive Skewness", Skewness.findSkew(nums));
        }

        [TestMethod()]
        public void simpleRandomTest()
        {
            Assert.AreEqual(5, Simple.randomSamplingInt(20, 5).Length);
        }

        [TestMethod()]
        public void systematicTest()
        {
            Assert.AreEqual(5, Systematic.sampling(20, 5).Length);
        }
    }
}