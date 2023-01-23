using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    public class SwapNumber
    {
        public  void  SwappingNum()
        {
            Console.WriteLine("Enter The First Number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping value of first " + no1);
            Console.WriteLine("Before Swapping value of second Number"+no2);
            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("After Swapping value of first Number"+ no1);
            Console.WriteLine("After Swapping value of second Number "+no2);
            Console.ReadLine();

        }

    }
}
