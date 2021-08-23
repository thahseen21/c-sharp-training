using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        // Condition to test non-zero value
        [TestMethod, TestCategory("TriangleTest")]
        public void TriangleTestMethod1()
        {
            float[] triangle = { 10f, 20f };
            var result = triangle.FindArea();
            Assert
                .AreNotEqual(0,
                result,
                "The value of the sides should not be zero");
        }

        //Condition to test non-negative value
        [TestMethod, TestCategory("TriangleTest")]
        public void TriangleTestMethod2()
        {
            float[] triangle = { 10f, 20f };
            var result = triangle.FindArea();
            Assert
                .IsTrue(result > 0,
                "Please enter the base and height greater than 0");
        }
    }
}
