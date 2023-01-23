using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    public class LargeNumber
    {
        public void LargeNo()
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());  
            int c=Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("A is greter Number");
            else if (b > a && b > c)
                Console.WriteLine("B is greter Number");
            else
                Console.WriteLine("c is greater");
            Console.ReadLine();
        }
       
    }
}
