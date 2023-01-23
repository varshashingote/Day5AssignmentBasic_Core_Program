using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    internal class Leapyear
    {
        public void Leap() 
        {
            Console.WriteLine("Enter the Number");
            int Year = Convert.ToInt32(Console.ReadLine());
            if(Year %4 ==0 &&  (Year%100 != 0) ||( Year % 400 ==0))
            {
                Console.WriteLine("{0} is Leap Year", Year);
            }
            else
            {
                Console.WriteLine("{0} is not leap Year",Year);
                Console.ReadLine();
            }
        }
    }
}
