using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miravil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fruits;

            Console.WriteLine("Enter the total price of 6 apple(s) :");
            fruits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total price of 6 people(s) :");
            double total1 = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("The total price of 6 people(s) : ");
            double total2 = Convert.ToDouble(Console.ReadLine());
            int total3 = (int) total2;        

            Console.WriteLine("The value of original price is " + total1);
            Console.WriteLine("The value of converted price is " + total3);
            Console.ReadKey();

        }
    }
}
