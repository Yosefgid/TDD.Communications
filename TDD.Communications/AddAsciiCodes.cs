using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Communications
{
    public class AddAsciiCodes
    {
        public int AddAscii_Codes(string input)
        {

            //casting a char into an int produces its ASCII values
            //return (int)input[0];
            return input.Sum(x => (int)x);


        }
    }
}
