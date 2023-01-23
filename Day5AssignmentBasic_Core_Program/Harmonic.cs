using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    internal class Harmonic
    {
        public void harmonicNumber()
        {
            int i, n;
            double s = 0.0;
            Console.WriteLine("Enter the Number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<n;i++)
            {
                Console.WriteLine("1/{0}+",i);
                s+= 1 / (float)i;

            }
            Console.WriteLine("Sum of series upto {0} terms:{1} \n ",n,s);
            Console.ReadLine();
        }
    }
}
