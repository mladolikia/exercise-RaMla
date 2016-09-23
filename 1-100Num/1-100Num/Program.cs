using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100Num
{
    class Program
    {
        static void Main(string[] args)
        {
           
            uint num = uint.Parse(Console.ReadLine());
            uint hundred = num / 100;
            uint tenth = (num / 10) % 10;
            uint unit = num % 10;
            string str = null;
            string[] units = { null,  "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
            
            string[] tenths = {  null, "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            

            if ((num >= 0) && (num <= 19))
            {
                str = units[num];
            }
            if (num == 20)
            {
                str = tenths[tenth];
            }
            if ((num > 20) && (num <= 29))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 30)
            {
                str = tenths[tenth];
            }
            if ((num > 30) && (num <= 39))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 40)
            {
                str = tenths[tenth];
            }
            if ((num > 40) && (num <= 49))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 50)
            {
                str = tenths[tenth];
            }
            if ((num > 50) && (num <= 59))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 60)
            {
                str = tenths[tenth];
            }
            if ((num > 60) && (num <= 69))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 70)
            {
                str = tenths[tenth];
            }
            if ((num > 70) && (num <= 79))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 80)
            {
                str = tenths[tenth];
            }
            if ((num > 80) && (num <= 89))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 90)
            {
                str = tenths[tenth];
            }
            if ((num > 90) && (num <= 99))
            {
                str = tenths[tenth] + " " + units[unit];
            }
            if (num == 100)
            {
                str = "one hundred";
               
            }
            if (num == 0)
            {
                str = "zero";

            }
            if (num >= 101)
            {
                str = "invalid number";

            }

            Console.WriteLine(str);



        }
    }
}
