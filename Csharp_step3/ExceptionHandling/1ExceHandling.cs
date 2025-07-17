using System;


//Syntax:
//try
//{
//    // Code that may throw an exception
//}
//catch (Exception ex)
//{
//    // Handle the exception
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//finally
//{

//}



namespace ExceptionHandling1
{
    class TestClass
    {

        public static void firstMethod(string input)
        {
            //string str = null;
            try
            {
                int length = input.Length;
                Console.WriteLine(length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

                //throw
            }
        }


        public static void secondMethod()
        {

            //int.Parse("abcded");
            //string str = null;
            try
            {
                int.Parse("abcd");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format is not good");
            }
        }


    }


    //console.readline and console.writeline
    class Program
    {
        public static void Main()
        {
            TestClass.firstMethod(null);

            //TestClass.secondMethod();

            Console.WriteLine("Program completed");
        }
    }
}