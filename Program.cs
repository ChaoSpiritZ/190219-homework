using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            /*
            Console.WriteLine("division test!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("yessss");
            }
            else
            {
                Console.WriteLine("no.......");
            }
            */
            //question 2
            /*
            Console.WriteLine("sum and average!! woot!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            double average = sum / 2.0;
            Console.WriteLine("sum is " + sum);
            Console.WriteLine("average is " + average);
            */
            //question 3
            /*
            int sum = 0;
            Console.WriteLine("enter numbers to sum (negative to exit)");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x >= 0)
            {
             sum = sum + x;
             x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the sum is " + sum);
            */
            //question 4
            /*
            Console.WriteLine("enter a whole number that is bigger than 1");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (a % i != 0 && i < a)
            {
                i++;
            }
            if (a == i)
            {
                Console.WriteLine("prime!");
            }
            else
            {
                Console.WriteLine("not prime!");
            }
            */
            //question 5
            /*
            Console.WriteLine("secret number time!");
            int s = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());

            while (s != g)
            {
                if (g > s)
                {
                    Console.WriteLine("too big");
                }
                else
                {
                    Console.WriteLine("too small");
                }
                g = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("bingo");
            */
            //question 6
            /*
            Console.WriteLine("factorial time!");

            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            Int64 factorial = 1;
                while (a != i)
                {
                i++;
                factorial = factorial * i;
                }
            Console.WriteLine(factorial);
            */
            //question 7
            /*
            Console.WriteLine("multiply without multiplying time!");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int mul = 0;
            int i = 1;
            while (i <= b)
            {
                mul = mul + a;
                i++;
            }
            Console.WriteLine(mul);
            */
        }
    }
}
