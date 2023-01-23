using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    internal class Factorial
    {
        public void factNum()
        {
            int i, fact = 1;
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of Number:" + fact);
            Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}



