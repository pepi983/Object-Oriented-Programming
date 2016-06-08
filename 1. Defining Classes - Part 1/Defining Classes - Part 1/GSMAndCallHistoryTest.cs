using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSMAndCallHistoryTest
    {
        static void Main(string[] args)
        {
            GSMTest();
            CallHistoryTest();
        }

        static void GSMTest()
        {
            Console.WriteLine("--------------------------------GSM Test--------------------------------");
           
            //Create an array of few instances of the GSM class.
            GSM[] phones = new GSM[]
            {
                new GSM("S5", "Samsung", 1000, "Merhat",
                    new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000)),
                new GSM("S7", "Samsung", 3000, "Ivan",
                    new Battery("G5", 422, 134, BatteryType.NiMH), new Display(7, 323145151)),
                new GSM("IPhone 6S", "Apple", 3000, "Drago",
                    new Battery("G5", 444, 155, BatteryType.Toshiba), new Display(12, 51515561))
            };

            //Display the information about the GSMs in the array.
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }

            //Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone4S);
        }

        static void CallHistoryTest()
        {
            Console.WriteLine("-----------------------------Call History Test-----------------------------");
            //Create an instance of the GSM class.
            GSM samsung = new GSM ("S5", "Samsung", 1000, "Merhat", new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000));
          
            //Add few calls.
            samsung.AddCall(new Call("31/06/2016", "14:06", "0884089756", 104));
            samsung.AddCall(new Call("23/03/2015", "12:42", "0423208975", 511));
            samsung.AddCall(new Call("31/06/2016", "11:12", "0852589752", 151));

            //Display the information about the calls.
            for (int i = 0; i < samsung.CallHistory.Count; i++)
            {
                Console.WriteLine(samsung.CallHistory[i]);
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Calls Price: {0:f2}", samsung.GetTotalCallPrice(0.37m));

            //Remove the longest call from the history and calculate the total price again.
            Call longestCall = samsung.CallHistory[0];
            foreach (var call in samsung.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            samsung.DeleteCall(longestCall);
            Console.WriteLine("Calls Price without longest: {0:f2}", samsung.GetTotalCallPrice(0.37m));

            //Finally clear the call history and print it.
            samsung.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
        }
    }
}
