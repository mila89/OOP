using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        private const int NumberLenght = 7; 
        public void CallOtherPhones(string number)
        {
            //if (ContainsChar(number) || number.Length!=NumberLenght)
            //    throw new ArgumentException("Invalid number!");
            Console.WriteLine($"Dialing... {number}");
        }

        private bool ContainsChar(string num)
        {
            foreach (var n in num.Where(n => Char.IsLetter(n)))
            {
                return true;
            }
            return false;
        }
    }
}
