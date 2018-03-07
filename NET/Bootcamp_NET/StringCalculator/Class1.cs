using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {

        public static int Calculate(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
            var integers = new List<int>();

            var strings = str
                .Split(',')
                .ToList();

            if (strings.Count != 2 || strings.Any(aChar => !int.TryParse(aChar, out int parsedValue)))
            {
                return 0;
            }
            
            return strings
                .Sum(aChar => int.Parse(aChar));
            //var sum = 0;

            //if (strings.Count != 2)
            //{
            //    return 0;
            //}

            //foreach (var aChar in strings)
            //{
            //    if (int.TryParse(aChar, out int parsedValue))
            //    {
            //        sum += parsedValue;
            //        continue;
            //    }

            //    return 0;
            //}

            //return sum;
        }
    }
}
