using System;
using System.Text;

namespace CustomConverter
{
    /// <summary>
    /// Converts double base-ten number
    /// into binary number
    /// </summary>
    static public class CustomConverter
    {
        public static string BinaryConvert(this double x)
        {
            if (double.IsInfinity(x))
            {
                int sign = Math.Sign(x) == 1 ? 0 : 1;
                return sign + new string('1', 11) + new string('0', 52);

            }
            else if (double.IsNaN(x))
            {
                return 1 + new string('1', 11) + "1" + new string('0', 51);
            }
            else
            {
                int sign = 1 / x == double.PositiveInfinity || Math.Sign(x) == 1  ? 0 : 1;
                return Convertation(Math.Abs(x), sign, 0);
            }
        }

        static string Convertation(double number, int sign,int exponent)
        {
            string result = "";
            double real = Math.Floor(number);
            double decim = number - real;
            //add mantissa           
            bool flag = false;
            //converting integer part
            while (real > 0 && result.Length < 53)
            {
                if (flag)
                {
                    result = real % 2 + result;
                    real = Math.Floor(real / 2);
                    exponent++;
                }
                else
                {
                    if (real % 2 == 1)
                    {
                        flag = true;
                        exponent--;
                    }
                    else
                    {
                        real = real / 2;
                        exponent++;
                    }
                }
            }
            //converting fractional part
            if (result.Length > 0)
            {
                result = result.Remove(0, 1);
                while (result.Length < 52)
                {
                    decim *= 2;
                    result = result + Math.Floor(decim);
                    decim -= Math.Floor(decim);
                }
            }
            //if integer part is empty
            else
            {
                while (result.Length < 52)
                {
                    if (flag)
                    {
                        decim *= 2;
                        result = result + Math.Floor(decim);
                        decim -= Math.Floor(decim);
                    }
                    //try to find first decimal 1 
                    if (!flag)
                    {
                        exponent--;
                        if (exponent == -1023)
                        {
                            flag = true;
                            continue;
                        }
                        if (Math.Floor(decim * 2) == 1)
                        {
                            flag = true;
                            decim *= 2;
                            decim -= Math.Floor(decim);
                        }
                        else decim *= 2;
                    }
                }
            }

            exponent += 1023;
            //add exponent
            while (result.Length < 63)
            {
                result = exponent % 2 + result;
                exponent = exponent / 2;
            }

            return sign + result;
        }

    }

}
