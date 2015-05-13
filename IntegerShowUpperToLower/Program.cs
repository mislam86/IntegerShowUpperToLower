using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerShowUpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers:");
            int firtNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firtNumber > secondNumber)
            {
                int temp = secondNumber;
                secondNumber = firtNumber;
                firtNumber = temp;
            }
            for (int i = firtNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }

    }
}
