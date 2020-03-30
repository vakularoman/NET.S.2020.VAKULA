using System;

namespace NET.S._2020.Vakula._6
{
    /// <summary>
    /// realisation of Polynomial class
    /// </summary>
    public class Polynomial
    {
        private readonly double[] coef;

        public double[] Coef
        {
            get { return coef; }

        }
        public Polynomial(double[] coefficient)
        {
            coef = coefficient;
        }

        /// <summary>
        /// override object.ToString()
        /// </summary>
        /// 
        public override string ToString()
        {
            if (coef is null) throw new NullReferenceException();

            string result = "";
            for(int i = 0; i < coef.Length;i++)
            {
                if (coef[i] == 0) continue;

                if (i == 0)
                {
                    if (coef[i] < 0) result +="-" + Math.Abs(coef[i]);
                    else result +=coef[i];
                }

                else if (result.Length == 0 && coef[i] > 0) result += coef[i] + "x^" + i;

                else if (coef[i] < 0) result += " - " +  Math.Abs(coef[i]) + "x^" + i;

                else result += " + " + coef[i] + "x^" + i;
            }
            return result;
        }
        /// <summary>
        /// override object.GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (coef is null) throw new NullReferenceException();
            for (int i = 1; i < coef.Length; i++)
                coef[0]+= coef[i];
            return (int)coef[0];
        }
        /// <summary>
        /// override object.Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (coef is null || obj is null) throw new NullReferenceException();

            if (!(obj is Polynomial))
                return false;

            Polynomial pol = (Polynomial)obj;
            if (pol.coef.Length != coef.Length)
                return false;

            for (int i = 0; i < coef.Length; i++)
            {
                if (pol.coef[i] != coef[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// override  + 
        /// </summary>
        /// <param name="firstPol"> first polynomial </param>
        /// <param name="secondPol"> second polynomial </param>
        /// <returns></returns>

        public static Polynomial operator + (Polynomial firstPol, Polynomial secondPol)
        {
            if (firstPol is null || secondPol is null) throw new NullReferenceException();

            double[] array = new double[firstPol.coef.Length > secondPol.coef.Length ? firstPol.coef.Length : secondPol.coef.Length];
            int i = 0;

            while (i < firstPol.coef.Length && i < secondPol.coef.Length)
            {
                array[i] = firstPol.coef[i] + secondPol.coef[i];
                i++;
            }
            while(i < firstPol.coef.Length)
            {
                array[i] = firstPol.coef[i];
                i++;
            }
            while(i < secondPol.coef.Length)
            {
                array[i] = secondPol.coef[i];
                i++;
            }

            return new Polynomial(array);
        }
        /// <summary>
        /// override - operator
        /// </summary>
        /// <param name="firstPol"></param>
        /// <param name="secondPol"></param>
        /// <returns></returns>
        public static Polynomial operator - (Polynomial firstPol, Polynomial secondPol)
        {
            if (firstPol is null || secondPol is null) throw new NullReferenceException();

            double[] array = new double[firstPol.coef.Length > secondPol.coef.Length ? firstPol.coef.Length : secondPol.coef.Length];
            int i = 0;

            while (i < firstPol.coef.Length && i < secondPol.coef.Length)
            {
                array[i] = firstPol.coef[i] - secondPol.coef[i];
                i++;
            }
            while (i < firstPol.coef.Length)
            {
                array[i] = firstPol.coef[i];
                i++;
            }
            while (i < secondPol.coef.Length)
            {
                array[i] = - secondPol.coef[i];
                i++;
            }

            return new Polynomial(array);
        }
        /// <summary>
        /// override * operator
        /// </summary>
        /// <param name="firstPol"></param>
        /// <param name="secondPol"></param>
        /// <returns></returns>
        public static Polynomial operator * (Polynomial firstPol, Polynomial secondPol)
        {
            if (firstPol is null || secondPol is null) throw new NullReferenceException();

            double[] array = new double[(firstPol.coef.Length ) + (secondPol.coef.Length ) - 1];

            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < firstPol.coef.Length; i++)
                {
                    if (i > k) break;

                    for (int j = 0; j < secondPol.coef.Length; j++)
                    {
                        if (i + j > k) break;
                        if (i + j == k) array[k] += firstPol.coef[i] * secondPol.coef[j];
                    }
                }
            }
            return new Polynomial(array);
        }

        /// <summary>
        /// override == != operators
        /// </summary>
        /// <param name="firstPol"> first polynomial</param>
        /// <param name="secondPol"> second polynomial</param>
        /// <returns></returns>
        public static bool operator == (Polynomial firstPol, Polynomial secondPol)
        {
            if (firstPol is null && secondPol is null) return true;
            if (firstPol is null || secondPol is null) return false; 

            if (firstPol.coef.Length != secondPol.coef.Length)
                return false;

            for (int i = 0; i < firstPol.coef.Length; i++)
            {
                if (firstPol.coef[i] != secondPol.coef[i])
                    return false;
            }
            return true;
        }

        public static bool operator != (Polynomial firstPol, Polynomial secondPol)
        {
            return !(firstPol == secondPol);
        }
    }
}
