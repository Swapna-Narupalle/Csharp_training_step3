using System;
using System.Xml.Schema;


namespace Extensions_DataTypes
{
    public static class StringExtensions
    {
       public static int WordCount(this string input)
       {
            string[] wordsCount = input.Split(' ');
            int length = wordsCount.Length;
            return length;
       }
    }

    class Program
    {
        static void Main()
        {
            string str = "I am swapna, from Kadapa";
            int length = str.WordCount();
            Console.WriteLine(length);

            string str1 = "Divya has a 3 years of experience in IT industry";
            int length1 = str1.WordCount();
            Console.WriteLine(length1);

            
        }
    }
}
