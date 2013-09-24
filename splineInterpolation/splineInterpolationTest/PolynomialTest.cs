using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using splineInterpolation;

namespace splineInterpolationTest
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void Polynomial_DefaultConstructorTest()
        {
            // arrange
            Polynomial poly = new Polynomial();
            double expected = 8.0;

            // act
            double actual = poly.getValue(2.0);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "The value of the polynomial is calculated incorrectly.");
        }

        [TestMethod]
        public void Polynomial_GetRightResult()
        {
            // arrange
            List<double> coefficients = new List<double>();
            coefficients.Add(4.0);
            coefficients.Add(3.0);
            coefficients.Add(2.0);
            coefficients.Add(1.0);
            
            Polynomial poly = new Polynomial(coefficients);

            double expected = 26.0;

            // act
            double actual = poly.getValue(2.0);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "The value of the polynomial is calculated incorrectly.");
        }
    }
}
