using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentBasic_Core_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Welcome to Basic Program ::");
                Console.WriteLine("Please Enter any one program you want to execute!!!");
                Console.WriteLine("1:SwapNumber\n2:EvenOddNumber\n3:LargeNumber \n4:Factorial\n5:VowelorConstant\n6:QuoDiv\n7:tabl2\n8:Harmonic\n9:Leapyear\n10FilpCoin" +
                    "\n5:FindSumOfDigit\n6:PrimeNumber");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SwapNumber sn = new SwapNumber();
                        sn.SwappingNum();
                        break;
                    case 2:
                        EvenOddNumbercs evenOdd=new EvenOddNumbercs();
                        evenOdd.EvenNo();
                        break;
                    case 3:
                        LargeNumber ln= new LargeNumber();
                        ln.LargeNo();
                        break;
                    case 4:
                        Factorial fn= new Factorial();
                        fn.factNum();
                        break;
                    case 5:
                        VowelorConstant vc = new VowelorConstant();
                        vc.character();
                        break;
                    case 6:
                        QuoDiv Qc=new QuoDiv();
                        Qc.Div();
                        break;
                    case 7:
                        table2 tn= new table2();
                        tn.mul();
                        break;
                    case 8:
                        Harmonic hn = new Harmonic();
                        hn.harmonicNumber();
                        break;
                    case 9:
                        Leapyear lp = new Leapyear();
                        lp.Leap();
                        break;
                    case 10:
                        FilpCons fcn = new FilpCons();
                        fcn.findPercentageofFilpCoin();
                        break;
                    default:

                        Console.WriteLine("OOOP's not avaliable sorry!!!!");
                        break;

                }
                Console.ReadLine();
                Console.WriteLine(" You like  this program !!!!!!!!!!! Do you want to continoue press(Y/N)");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "N");



        }
    }
}
