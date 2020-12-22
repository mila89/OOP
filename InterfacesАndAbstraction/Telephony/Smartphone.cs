using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowsing, ICalling
    {
        //private const string MessageNum = "Invalid number!";
        //private const string MessageURL = "Invalid URL!";
        //private const int NumberLenght = 10;


        public void CallOtherPhones(string num)
        {
            Console.WriteLine($"Calling... {num}");
        }

       public void Browse(string site)
        {
            Console.WriteLine($"Browsing: {site}!");
        }
    }
}
