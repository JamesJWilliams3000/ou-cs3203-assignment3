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
            int[] numbers = ParseParameters(args);

            Console.WriteLine("The sum is: " + Sum(numbers));
            Console.WriteLine("The product is: " + Mutiply(numbers));

            Console.ReadKey();
        }

        private static int[] ParseParameters(string[] args)
        {
            int[] numbers = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = Int32.Parse(args[i]);
            }

            return numbers;
        }

        private static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        private static int Mutiply(int[] numbers)
        {
            int product = 1; //dont multiply by 0
            foreach (var num in numbers)
            {
                product *= num;
            }

            return product;
        }
    }
}
