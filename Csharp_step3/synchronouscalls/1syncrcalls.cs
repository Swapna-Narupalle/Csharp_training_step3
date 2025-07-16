using System;
using System.Threading;

namespace synchronous_calls
{
    class CsharpProgramExecution
    {
        public static void WriteCsharpProgram()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(5000);//Method which gives the sleep time
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;//5ms
            Console.WriteLine($"Completed the writing of Csharp program. Elapsed time: {elapsedTime.TotalMilliseconds}ms.");
        }
        public static void BuildCsharpprogram()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(3000);
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;//3ms
            Console.WriteLine($"Build is Completed for Csharp Program. Elapsed Time: {elapsedTime.TotalMilliseconds}ms");
        }
        public static void RunCharpProgram()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(2000);
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;//2ms
            Console.WriteLine($"Csharp Program is executed successfully. Elapsed Time: {elapsedTime.TotalMilliseconds}ms");
        }

    }
    class CsharpProgram
    {
        public static void CsharpExecution() 
        {
            Console.WriteLine("Sequential Works started step by step");
            var CsharpProgramStartTime = DateTime.Now;

            CsharpProgramExecution.WriteCsharpProgram();
            CsharpProgramExecution.BuildCsharpprogram();
            CsharpProgramExecution.RunCharpProgram();

            var CsharpProgramEndTime = DateTime.Now;
            var CsharpProgramElapsedTime = CsharpProgramEndTime - CsharpProgramStartTime;//10ms
            Console.WriteLine($"Charp Program executed successfully. Total elapsed Time: {CsharpProgramElapsedTime.TotalMilliseconds}");
        }
       

    }
    class Program
    {
       static void Main()
       {
            CsharpProgram.CsharpExecution();
       }
    }
}
