using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//james williams
//

namespace ou_cs3203_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is: " + Sum(args));
            Console.ReadKey();
        }

        private static int Sum(string[] args)
        {
            int sum = 0;
            foreach (var arg in args)
            {
                //insert error checking here
                int num = Int32.Parse(arg);
                sum += num;
            }

            return sum;
        }
    }
}
