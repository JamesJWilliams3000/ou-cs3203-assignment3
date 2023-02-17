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
            Console.Write("Please input a list of integers separated by a space: ");
            int[] numbers = ParseParameters(Console.ReadLine());
            Console.WriteLine("The reversed list is: " + String.Join(" ", ReverseArray(numbers)));

            Console.WriteLine("The sum is: " + Sum(numbers));
            Console.WriteLine("The product is: " + Mutiply(numbers));

            Console.ReadKey();
        }

        private static int[] ReverseArray(int[] numbers)
        {
            return numbers.Reverse().ToArray();
        }

        //parses from a single line of input separated by a space
        private static int[] ParseParameters(string input)
        {
            string[] inputArray = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return ParseParameters(inputArray);
        }

        //parses from command line parameters
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
