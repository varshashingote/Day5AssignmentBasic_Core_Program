using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    internal class FilpCons
    {
        public void findPercentageofFilpCoin()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {


                double randomInpout = random.NextDouble();
                if (randomInpout < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }

                Console.WriteLine("TailCount:{0} headCount :{1}", tailCount, headCount);
                Console.WriteLine("Tail  percentage:{0}%", (tailCount * 100) / n);
                Console.WriteLine("HEad percentage:{0}%", (headCount * 100) / n);
                Console.ReadLine();
            }
        }
    }
}


        

    