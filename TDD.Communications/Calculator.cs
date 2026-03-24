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
            //We are using orderBy method and using arrow/lambda function to sort the numbers 
            // n refers to the current instance of a number from the numbers array
            //n => n this is saying use this numberr to sort and will return n
            //let us say numbers = {5, 2, 9}
            //numbers[0] = num =5
            //return 5 for 5 and 2 for 2 and 9 for 9 then toArray puts them in a new array
            //and then orderby orders the numbers 
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

