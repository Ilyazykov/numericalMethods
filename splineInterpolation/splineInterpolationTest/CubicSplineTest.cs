using System;
using splineInterpolation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace splineInterpolationTest
{
    [TestClass]
    public class CubicSplineTest
    {
        [TestMethod]
        public void CubicSpline_GetResult()
        {
            // arrange
            CubicSpline spline = new CubicSpline();
            double expected = Math.Sin(0.5);

            // act
            double actual = spline.getValue(0.5);

            // assert
            Assert.AreEqual(expected, actual, 0.1, "The value of spline and sin is too different");
        }
    }
}
