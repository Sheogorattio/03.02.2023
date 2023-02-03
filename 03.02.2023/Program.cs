using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            {
                Random r = new Random();
                int[][] mixedArr = new int[r.Next(4, 6)][];
                for(int i=0; i < mixedArr.Length; i++)
                {
                    mixedArr[i] = new int [r.Next(1,10)];
                    for(int j=0; j < mixedArr[i].Length; j++) Console.Write($"{ mixedArr[i][j] = 0} ");
                    Console.WriteLine();
                }
                int maxIndex = 0, minIndex = 0, maxLen= mixedArr[0].Length, minLen = mixedArr[0].Length;
                for(int i=0; i < mixedArr.Length; i++)
                {
                    if (maxLen < mixedArr[i].Length)
                    {
                        maxIndex = i;
                        maxLen = mixedArr[i].Length;
                    }
                    if (minLen > mixedArr[i].Length)
                    {
                        minIndex = i;
                        minLen = mixedArr[i].Length;
                    }
                }
                (mixedArr[maxIndex], mixedArr[minIndex]) = (mixedArr[minIndex], mixedArr[maxIndex]);
                Console.WriteLine($"Max index:\t{maxIndex}\nMin index:\t{minIndex}");
                Console.WriteLine("Edited:");
                foreach (int[] arr in mixedArr)
                {
                    foreach(int i in arr) Console.Write($"{i} ");
                    Console.WriteLine();
                }
            }
            #endregion
            Console.WriteLine("----------------------------");
            #region task 2
            {
                int[][] mixedArr = new int[4][];
                for (int i = 0; i < mixedArr.Length - 1; i++)
                {
                    mixedArr[i] = new int[6 - i];
                    for (int j = 0; j < mixedArr[i].Length; j++) Console.Write($"{mixedArr[i][j] = 0} ");
                    Console.WriteLine();
                }
                mixedArr[3] = new int[2];
                for(int i=0; i< mixedArr[3].Length; i++) Console.Write($"{ mixedArr[3][i] = 0} ");              
                Console.WriteLine();
            }
            #endregion
            Console.Read();
        }
    }
}
