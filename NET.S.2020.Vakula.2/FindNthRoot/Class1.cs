using System;

namespace FindNthRoot
{
    public static class NewtonRoot
    {
        /// <summary>
        /// find number degree root with
        /// given accuracy
        /// </summary>
        /// <param name="value">initial number</param>
        /// <param name="degree">degree of the root</param>
        /// <param name="accuracy">accuracy of expected number</param>
        /// <returns></returns>
        public static double FindNthRoot(double value,double degree,double accuracy)
        {
            if (degree < 0 || accuracy < 0) throw new ArgumentException();

            double next_val = value / degree;
            double prev_val;
            //xn+1 = xn - f(x)/f'(x)
            do
            {
                prev_val = next_val;
                next_val = prev_val - (Math.Pow(prev_val, degree) - value) /
                    (degree * Math.Pow(prev_val, degree - 1));

            } while (Math.Abs(prev_val - next_val) > accuracy);
            //fractional part length = accuracy
            return Math.Round(next_val - next_val% accuracy, accuracy.ToString().Length - 2);
            
        }
    }
}
