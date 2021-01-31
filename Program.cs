using System;
using System.Linq;

namespace PrintArrayPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                int currNumber = arrNumbers[i];

                for (int j = i+1; j < arrNumbers.Length; j++)
                {
                    int sumPairs = currNumber + arrNumbers[j];

                    if (sumPairs == inputNumber)
                    {
                        Console.WriteLine(currNumber + " " + arrNumbers[j]);
                    }

                }

                


            }
        }
    }
}
