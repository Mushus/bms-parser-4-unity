using System.Collections.Generic;

namespace BMS
{
    public class Base36
    {
        private static string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Encode(int val)
        {
            var digits = "";
            while (val > 0)
            {
                var digit = val % Digits.Length;
                val = val / Digits.Length;
                digits = Digits[digit] + digits;
            }
            digits = "00" + digits;
            return digits.Substring(digits.Length - 2, 2);
        }

        public static int Decode(string val)
        {
            var result = 0;
            for (var i = 0; i < val.Length; i++)
            {
                result *= Digits.Length;
                result += Digits.IndexOf(val[i]);
            }
            return result;
        }
    }
}