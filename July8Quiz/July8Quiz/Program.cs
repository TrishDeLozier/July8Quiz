using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July8Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int value = ArrayOdds(numbers);
            Console.ReadLine();
                
        }

        static public int ArrayOdds(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i+=2 )
                Console.WriteLine(numbers[i]);
            return 0;
        }
    }
}
