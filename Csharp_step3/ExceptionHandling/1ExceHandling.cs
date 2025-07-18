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
    public class TestClass
    {
        public static void FirstMethod(string input)
        {
            try 
            {
                int length = input.Length;
                Console.WriteLine(length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public static void SecondMethod()
        {
            try
            {
                int.Parse("Swapna");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format is not correct");
            }
            
        }

        public static void ThirdMethod(string input1, string input2, int first, int second)
        {
            try
            {
                int length = input1.Length;
                Console.WriteLine(length);

                int.Parse(input2);

                int result = first / second;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format is not good");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Argument is not good");
                Console.WriteLine(ex.Message);
            }
        }

        public static void FourthMethod()
        {
            try
            {
                int age = -15;
                if (age > 0)
                {
                    Console.WriteLine($"your age is: {age}");
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Argument exception is occured: " + ex.Message);
            }
            
        }

        public static void FifthMethod(string input1, string input2, int first, int second)
        {
            try
            {
                int length = input1.Length;
                Console.WriteLine(length);

                // try
                // {
                //     int.Parse(input2);
                // }
                // catch(FormatException ex)
                // {
                //    Console.WriteLine("Format is not good");
                //     Console.WriteLine(ex.Message);
                // }

                int.Parse(input2);

                int result = first / second;
            }
            catch (NullReferenceException ex)
            {
                int a = 10;
                int b = 5;
                try
                {
                    int c = a / b;
                }
                catch(DivideByZeroException dx)
                {
                    Console.WriteLine(dx.Message);
                }

                Console.WriteLine("value should not be nothing");
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Argument is not good");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void SixthMethod(string input1, string input2, int first, int second)
        {
            try
            {
                int length = input1.Length;
                Console.WriteLine(length);

                int.Parse(input2);

                int result = first / second;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something has happend!!! please check all your inputs");
                Console.WriteLine(ex.Message);
            }
        }
        
    }

    class Program
    {
        public static void Main()
        {
            // TestClass.FirstMethod(null);
            //TestClass.SecondMethod();
            // TestClass.ThirdMethod("Hello", "123", 10, 0);
            //TestClass.FourthMethod();
            //TestClass.FifthMethod("Rushi", "rushi", 5, 2);
            TestClass.SixthMethod("Hello", "Hellooo", 10, 2);

            Console.WriteLine("Program completed");
        }
    }
}