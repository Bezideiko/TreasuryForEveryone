using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.I.Homework;

namespace GSMCallHistoryTest
{
      class GSMCallHistoryTest
      {
            static void Main()
            {
                  GSM myPhone = new GSM("BlackBerry", "RIM", 600, "ASE");
                  Call callToFriend = new Call(DateTime.Now, "+359 985545331", 24);
                  Call callToGirlfriend = new Call(new DateTime(2013, 02, 12), "0556 034112", 2676);
                  Call callToTheOtherGirlfriend = new Call(new DateTime(2013, 02, 13), "0946 543312", 4212);
                  myPhone.AddCall(callToFriend);
                  myPhone.AddCall(callToGirlfriend);
                  myPhone.AddCall(callToTheOtherGirlfriend);
                  int counter = 1;
                  foreach (Call call in myPhone.CallHistory)
                  {
                        Console.WriteLine(counter + ": " + "Date of the call is: {0}.", call.Date);
                        Console.WriteLine("   " + "The dialed number is: {0}.", call.DialedNumber);
                        Console.WriteLine("   " + "The duration of the call is: {0} seconds.", call.Duration);
                        Console.WriteLine();
                        counter++;
                  }

                  Console.WriteLine("The total price of all calls is: {0} lv.", myPhone.TotalPrice(0.37m));
                  Console.WriteLine();

                  Call longestCall = null;
                  for (int i = 0; i < myPhone.CallHistory.Count - 1; i++)
                  {
                        longestCall = myPhone.CallHistory[i].Duration >= myPhone.CallHistory[i + 1].Duration ? longestCall = myPhone.CallHistory[i] : longestCall = myPhone.CallHistory[i + 1];
                  }
                  myPhone.DeleteCall(longestCall);
                  Console.WriteLine("The total price of all calls without the longest call is: {0} lv.", myPhone.TotalPrice(0.37m));
                  Console.WriteLine();

                  myPhone.ClearCallHistory();
                  Console.WriteLine("Calls left after clearing the call history: ");
                  foreach (Call call in myPhone.CallHistory)
                  {
                        Console.WriteLine(call.ToString());
                  }
            }
      }
}
