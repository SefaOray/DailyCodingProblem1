using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Given a list of numbers, returns whether any two sums to sum. 
        /// </summary>
        /// <param name="numArray">Array to look for pair</param>
        /// <param name="sum">Sum to look for</param>
        /// <returns>Returns pair that adds up to sum, returns empty array if a pair is not found.</returns>
        public static int[] PairWithSum(int[] numArray, int sum)
        {
            //This list will contain numbers we have seen before. 
            var compPair = new SortedList();

            for(int i = 0; i < numArray.Length; i++)
            {
                
                var targetNum = sum - numArray[i];

                //Check if we seen the completing number before
                if(compPair.ContainsKey(numArray[i]))
                {
                    return new int[] { numArray[i], targetNum };
                }

                //Add this number to seen numbers
                compPair.Add(targetNum, i);
            }

            return new int[2]; 
        }
    }
}
