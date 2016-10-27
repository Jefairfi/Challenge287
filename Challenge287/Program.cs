using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge287
{
    public class Program
    {
        static void Main(string[] args)
        {
            var maxValue = (int?)0;
            for (int i = 0; i < 9999; i++)
            {
                var result = kaprekar(i);
                if (result > maxValue)
                {
                    maxValue = result;
                }
            }
        }

        public static int largest_digit(int input)
        {
            var maxChar = input.ToString().Max();
            return int.Parse(maxChar.ToString());
        }

        public static int descending_digits(int input)
        {
            var orderedList = input.ToString().OrderByDescending(x => x);
            return int.Parse(string.Join("", orderedList).PadRight(4, '0'));
        }

        public static int ascending_digits(int input)
        {
            var ascendingList = input.ToString().OrderBy(x => x);
            return int.Parse(string.Join("", ascendingList));
        }

        public static int? kaprekar(int input)
        {
            var cnt = 0;
            if (input > 0 && input < 10000)
            {
                return null;
            }
            while (input != 6174)
            {
                cnt++;
                input = descending_digits(input) - ascending_digits(input);
                if (input == 0)
                {
                    return null;
                }
            }
            return cnt;
        }
    }
}
