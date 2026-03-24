using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Communications
{
    public class Calculator
    {
        public int SumMiddleNumbers(int[] numbers)
        {
            if (numbers.Length <= 2)
                return 0;
            //Numbers is sorted by ascending order

            var sorted = numbers.OrderBy(num => num).ToArray();

            var lowest = sorted[0];
            var highest = sorted[^1];

            //create a sum with a value of zero
            int sum = 0;

            foreach(var num in numbers)
            {
                sum += num;
            }

            return sum - lowest - highest;

               
        }
    }
}

