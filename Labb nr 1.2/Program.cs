using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_nr_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int CashRecieved;
            double Cost;
            int totalCost;
            double cashRound;
            int Change;
            

            Console.Write("Enter Total Sum : ");
            Cost = double.Parse(Console.ReadLine());

            Console.Write("Enter Amount Recieved : ");
            CashRecieved = int.Parse(Console.ReadLine());
            
            Console.Write("\n");
            Console.WriteLine("RECIPE");

            Console.WriteLine("------------------------------------------");

            totalCost = (int)Math.Round(Cost);
            Console.WriteLine("Cost                           : {0:c}", Cost);
            
            cashRound = totalCost - Cost;

            Console.WriteLine("Pennies                        : {0:f2} ", cashRound);

            Console.WriteLine("Rounded Sum                    : {0:c} ", totalCost);

            Console.WriteLine("Cash Recieved                  : {0:c} ", CashRecieved);

            Change = CashRecieved - totalCost;
            Console.WriteLine("Change Back                    : {0:c} ", Change);

            Console.WriteLine("------------------------------------------");

            if (Change > 500)
            {
                Console.WriteLine("500 Bills Back : {0:f0}", Change / 500);
                Change = Change % 500;
            }
            
            if (Change > 100)
            {
                Console.WriteLine("100 Bills Back : {0:f0}", Change / 100);
                Change = Change % 100;
            }
            
            if (Change > 50)
            {
                Console.WriteLine("50 Bills Back  : {0:f0}", Change / 50);
                Change = Change % 50;
            }

            if (Change > 20)
            {
                Console.WriteLine("20 Bills Back  : {0:f0}", Change / 20);
                Change = Change % 20;            
            }

            if (Change > 10)
            {
                Console.WriteLine("10 Crones Back : {0:f0}",(int) Change / 10);
                Change = Change % 10;
            }

            if (Change > 5)
            {
                Console.WriteLine("5 Crones Back  : {0:f0}", Change / 5);
                Change = Change % 5;
            }

            if (Change > 1)
            {
                Console.WriteLine("1 Crones Back  : {0:f0}", Change /1);
                Change = Change % 1;
            }





            



        }
    }
}
