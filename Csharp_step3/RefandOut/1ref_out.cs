using System;
using System.Xml.Linq;


class Methods_Three
{
    static void Main()
    {
        int number1 = 0;
        bool status1 = false;
        string ename1 = null;
        Console.WriteLine($"Before calling ref method-: number1: {number1}, status1:{status1}, name1: {ename1}");

        Methods_Three.RefParameterValues(ref number1, ref status1, ref ename1);
        Console.WriteLine($"After calling ref method is-: number1: {number1}, status1:{status1}, name1: {ename1}");

        int number2;
        bool status2;
        string ename2;
        //Console.WriteLine($"Before calling Out method-: number2: {number2}, status1:{status2}, name1: {ename2}");

        Methods_Three.OutParametervalues(out number2, out status2, out ename2);
        Console.WriteLine($"after calling Out method is-: number2: {number2}, status2:{status2}, name2: {ename2}");

        int number = 0;
        bool issuccess;
        string input = "10";

        Methods_Three.MTryParseInt(input, ref number, out issuccess);
        if (issuccess)
        {
            Console.WriteLine("Good. i have converted the your input");
        }
        else
        {
            Console.WriteLine("Sorry . Please check your input again");
        }


    }
    static void RefParameterValues(ref int id, ref bool status, ref string ename)
    {
        id = 20;
        status = true;
        ename = "Swapna";
    }
    static void OutParametervalues(out int id, out bool status, out string ename)
    {
        id = 50;
        status = true;
        ename = "Mouni";
    }
    static void MTryParseInt(string input, ref int number, out bool issuccess)
    {
        bool output = int.TryParse(input, out number);
        if (output)
        {
            issuccess = true;
        }
        else
        {
            number = -1;
            issuccess = false;
        }
    }
}

