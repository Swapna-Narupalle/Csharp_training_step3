// Boss is the Excecption


//SystemExpception derived class of the Exception (base)

//New expception parent class or 



using CustomExceptionNamespace;
using System;
using System.Collections.Generic;
using System.Linq;




//Below18OrGreather60Expectoin you are registing the cusomtexption to the systemExpception

namespace CustomExceptionNamespace
{
    //You need to call the constructor of the Exceptoin
    class Below18OrGreater60Exception : Exception
    {
        public Below18OrGreater60Exception() : base() { }  // Exception register your csutom exception
    }

    class Program
    {
        public static void ValidateAge(int age)// Image you get the value from textbox
        {
            
            if(age<18 || age > 60)
            {
                throw new Below18OrGreater60Exception();
            }
            else
            {
                Console.WriteLine($"Age {age} is valid in this process");
            }

        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
            }
            catch(Below18OrGreater60Exception ex)
            {
                Console.WriteLine("Please enter 18 to 60 number only");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Server is down" + ex.Message);
            }
        }
    }
}
