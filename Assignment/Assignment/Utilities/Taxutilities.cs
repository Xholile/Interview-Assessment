using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Utilities
{
    public class TaxUtilities
    {
        private const double ROUND_OFF = 0.05;

        public static double RoundOff(double value)
        {
            return (int)(value / ROUND_OFF + 0.5) * 0.05;
        }

        public static double Truncate(double value)
        {
            string result = value.ToString("N2"); ;
            return double.Parse(result);
        }

        public static bool BooleanParser(char value)
        {
            bool flag = true;
            bool boolValue = false;

            while (flag)
            {
                //parses 'Y' into 'true'
                if (value == 'Y' || value == 'y')
                {
                    boolValue = true;
                    flag = false;
                }

                //parses 'N' into 'false'
                else if (value == 'N' || value == 'n')
                {
                    boolValue = false;
                    flag = false;
                }

                //validates user input
                else
                {
                    Console.WriteLine("Invalid input. Enter (Y/N)");
                }
            }

            return boolValue;
        }

    }
}
