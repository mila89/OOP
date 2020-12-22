using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main()
        {
            string[] inputNum = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] inputSites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Smartphone smart = new Smartphone();
            StationaryPhone phone = new StationaryPhone();

            foreach (var number in inputNum)
            {
                if (!ValidNumber(number))
                    Console.WriteLine("Invalid number!");
                else
                {
                    if (number.Length == 10)
                        smart.CallOtherPhones(number);
                    else if (number.Length == 7)
                        phone.CallOtherPhones(number);
                }
            }
            foreach (var site in inputSites)
            {
                if (ContainsNum(site))
                    Console.WriteLine("Invalid URL!");
                else
                    smart.Browse(site);
            }         
        }

        private static bool ContainsNum(string site)
        {
            foreach (var ch in site.Where(ch => char.IsDigit(ch)))
            {
                return true;
            }
            return false;
        }

        private static bool ValidNumber(string number)
        {
            if (ContainsChar(number))
                return false;
            if (number.Length == 10 || number.Length == 7)
                return true;
            return false;
        }

        private static bool ContainsChar(string num)
        {
            foreach (var n in num.Where(n => Char.IsLetter(n)))
            {
                return true;
            }
            return false;
        }
    }
}
