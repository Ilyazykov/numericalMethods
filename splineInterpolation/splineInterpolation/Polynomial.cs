using System;
using System.Collections.Generic;

namespace splineInterpolation
{
    class Polynomial
    {
        private List<double> coefficients;

        public Polynomial()
        {
            coefficients.Add(0);
            coefficients.Add(0);
            coefficients.Add(0);
            coefficients.Add(1);
        }

        public Polynomial(List<double> coefficients)
        {
            this.coefficients = coefficients;
        }

        public double getValue(double x)
        {
            double degreeOfX = 1.0;
            double result = 0;
            foreach (double coefficient in coefficients)
            {
                result += coefficient * degreeOfX;
                degreeOfX *= x;
            }
            return result;
        }
    }
}
