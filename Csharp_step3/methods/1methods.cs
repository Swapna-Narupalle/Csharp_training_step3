using System;
using System.Xml.Serialization;

namespace MathProgram
{
    class Program
    {
        //find whether a number is even or odd in a array
        static string[] ProcessArray(int[] numbers)
        {
            //create a string array to store results
            string[] results = new string[numbers.Length];
            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    results[i] = $"{numbers[i]} is Even";
                }
                else
                {
                    results[i] = $"{numbers[i]} is Odd";
                }
            }
            return results;
        }

        static void Main()
        {
            Console.WriteLine("----check even or odd--------");
            int[] numbers = { 5, 6, 12, 16, 17, 21 };//input array
            string[] output = ProcessArray(numbers);
            Console.WriteLine(output);
            foreach(string result in output)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("\n-----check Positive/Negative/Zero-----");
            int[] numbers1 = { -1, 2, 0, 6, 0, -4 };
            string[] output1 = GetnumberType(numbers1);
            Console.WriteLine(output1);
            foreach (string result in output1)
            {
                Console.WriteLine(result);
            }
        }
    

   
    
        //find whether a number is positive, negative or zero in the array
        static string[] GetnumberType(int[] numbers1)
        {
            string[] results = new string[numbers1.Length];
            for(int i=0; i<numbers1.Length; i++)
            {
                if (numbers1[i] > 0)
                {
                    results[i] = $"{numbers1[i]} is positive number";
                }
                else if (numbers1[i] < 0)
                {
                    results[i] = $"{numbers1[i]} is negative number";
                }
                else
                {
                    results[i] = $"{numbers1[i]} is zero";
                }
            }
            return results;

        }
        
    }
}
