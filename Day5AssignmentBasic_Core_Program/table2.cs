using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
   public class table2
    {
        public void mul()
        {
            int i, n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<= 10;i++)
            {
             Console.WriteLine("{0}*{1}={2}", n, i, n*i);
             Console.ReadLine();
            }
        }
    }
}
