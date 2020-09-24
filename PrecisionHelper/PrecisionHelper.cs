using System;
using System.Globalization;
using System.Linq;

namespace V
{
    public static class PrecisionHelper
    {
        public static int NumbersAfterDot(decimal value) => Calculate((decimal)value);
        public static int NumbersAfterDot(double value) => Calculate((decimal)value);
        public static int NumbersAfterDot(float value) => Calculate((decimal)value);

        private static int Calculate(decimal str)
        {
            var decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            var splitted = str.ToString()
                              .Split(new[] { decimalSeparator }, StringSplitOptions.None);

            if (splitted.Length != 2)
                return 0;
            else
            {
                var count = splitted[1].Reverse()
                                       .SkipWhile(x => x == '0')
                                       .Count();
                return count;
            }
        }
    }
}