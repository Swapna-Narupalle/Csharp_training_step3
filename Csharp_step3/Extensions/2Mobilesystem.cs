using System;


// Top 5 Extension Method , Override methods

//extenison method simimoro normal method

//you can return void or non-void

//you can pass the parametesr

namespace PhoneSystem
{
    public class SmartPhone
    {
        public string Brand { get; set; }

        public void MakeCall(string phnumber)
        {
            Console.WriteLine($"Calling {phnumber} from {Brand} smartPhone");
        }
    }


    //TrackFitness and Playgame
    public static class SmartPhoneExtensions
    {
        public static void TrackFitness(this SmartPhone phone)
        {
            Console.WriteLine($"this {phone.Brand} smartphone is tracking fitness Now");
        }

        public static void PlayGame(this SmartPhone phone, string gameName)
        {
            Console.WriteLine($" Playing {gameName} on the {phone.Brand} smartphone");
        }
    }


    // Without modifying source code i want to add New functionlity(extension) to the class
    public class Program
    {
        static void Main()
        {

            SmartPhone myPhone = new SmartPhone() { Brand = "Pixel" };
            myPhone.MakeCall("7204185064");


            myPhone.TrackFitness();
            myPhone.PlayGame("Chess");



            //str.word

            //Example


            // 5 Other tasks


        }
    }






}