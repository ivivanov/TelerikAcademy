using System;
using System.Collections.Generic;
using MobilePhone;

namespace GSMTest
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM justInstance = new GSM();

            //Testing full parameter ctor
            Console.WriteLine(new string('-', 80));
            GSM Nokia = new GSM("E52", "Nokia", 200.0m, "Ivan", new Battery("2000 mAh", 12.3, 4.5, BatteryType.NiMH), new Display(2.6, 16000000));
            Console.WriteLine("\nTesting full parameter ctor");
            Console.WriteLine(Nokia.ToString());

            //Testing full param ctor with default Battery and Display
            Console.WriteLine(new string('-', 80));
            GSM Nokia1 = new GSM("E52", "Nokia", 200.0m, "Ivan", new Battery(), new Display());
            Console.WriteLine("\nTesting full param ctor with default Battery and Display");
            Console.WriteLine(Nokia1.ToString());

            //Testing partial param ctor
            Console.WriteLine(new string('-', 80));
            GSM Nokia2 = new GSM("E52", "Nokia");
            Console.WriteLine("\nTesting partial param ctor");
            Console.WriteLine(Nokia2.ToString());


            ///////////////////////////TASK 7 tests//////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\nTASK 7 TEST START HERE !");
            GSM[] gsmList = new GSM[5];
            for (int i = 0; i < 5; i++)
            {
                gsmList[i] = Nokia;
            }
            foreach (GSM gsm in gsmList)
            {
                Console.WriteLine(gsm.ToString() + "\n");
            }
                
            Console.WriteLine("\nPrinting static field iPhone4s");
            Console.WriteLine(justInstance.IPhone4s);

            ///////////////////////////TASK 10 tests////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\nTASK 10 TEST START HERE !");
            GSM vladosPhone = new GSM("S35", "Siemens", 79.99m, "Vlado", new Battery("750mAh", 72, 6, BatteryType.LiIon), new Display(1.5, 64), null);
            vladosPhone.AddCalltoHistory(new Call("+359888555777",3600));
            vladosPhone.AddCalltoHistory(new Call("0000",0));
            vladosPhone.AddCalltoHistory(new Call("+359888000000",15));
            vladosPhone.AddCalltoHistory(new Call("0888555777",10));
            vladosPhone.AddCalltoHistory(new Call("028685512",20));
            vladosPhone.AddCalltoHistory(new Call("0359887551552",60));
            vladosPhone.PrintCallLog();
            vladosPhone.DeleteCallFromHistory(new Call("+359888555777"));
            vladosPhone.DeleteCallFromHistory(new Call("0000"));
            vladosPhone.DeleteCallFromHistory(new Call("+359888000000"));
            Console.WriteLine("Testing callHistory delete function:");
            vladosPhone.PrintCallLog();
            Console.WriteLine("Testing callHistory clear function:");
            vladosPhone.ClearHistory();
            vladosPhone.PrintCallLog();

            ///////////////////////////TASK 11 tests////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\nTASK 11 TEST START HERE !");
            vladosPhone.AddCalltoHistory(new Call("+359888555777", 3600));
            vladosPhone.AddCalltoHistory(new Call("+359888000000", 15));
            vladosPhone.AddCalltoHistory(new Call("0359887551552", 60));
            vladosPhone.CalculatePrice();

            ///////////////////////////TASK 12 tests////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\nTASK 12 TEST START HERE !");
            /*  Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
                Create an instance of the GSM class.
                Add few calls.
                Display the information about the calls.
                Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
                Remove the longest call from the history and calculate the total price again.
                Finally clear the call history and print it.
            */
            //Create an instance of the GSM class.
            GSM instance = new GSM();
            // Add few calls.
            instance.AddCalltoHistory(new Call("+359888555777", 3600));
            instance.AddCalltoHistory(new Call("+359888123321", 300));
            instance.AddCalltoHistory(new Call("0359888333222", 80));
            instance.AddCalltoHistory(new Call("028683939", 50));
            instance.AddCalltoHistory(new Call("+123000128937912837", 0));
            // Display the information about the calls.
            instance.PrintCallLog();
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            instance.CalculatePrice();
            //Remove the longest call from the history and calculate the total price again.
            instance.DeleteCallFromHistory(new Call("+359888555777"));
            instance.CalculatePrice();
            // Finally clear the call history and print it.
            instance.ClearHistory();
            instance.PrintCallLog();
        }
    }
}
 