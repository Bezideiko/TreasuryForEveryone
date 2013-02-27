using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.I.Homework;

namespace GSMTest
{
      class GSMTest
      {
          static void Main()
          {
                  GSM[] cellPhones = new GSM[4] 
                  { 
                        new GSM("Nokia", "China", 300, "Ivo Andonov"),
                        new GSM("HTC", "Thailand", 500, "Kosuma"),
                        new GSM("Samsung", "Vietnam", 400, "Shmekera"),
                        new GSM("Motorola", "India", 200, "Kukata")
                  };
                  for (int i = 0; i < cellPhones.Length; i++)
                  {
                        Console.WriteLine(cellPhones[i].GSMInfo().ToString()); 
                  }
                  Console.WriteLine(GSM.iPhone4S.Model);
                  Console.WriteLine(GSM.iPhone4S.Manufacturer);
          }
    }
}
