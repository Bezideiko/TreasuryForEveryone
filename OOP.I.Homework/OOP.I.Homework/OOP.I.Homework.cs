using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.I.Homework
{
    public class GSM
    {
          private string model = null;
          private string manufacturer = null;
          private decimal price = 0;
          private string owner = null;
          private Battery battery = null;
          private Display display = null;
          public static GSM iPhone4S = new GSM("IPhone4s", "Apple");                              // Task: 6
          public List<Call> callHistory = new List<Call>();                                       // Task: 9

          public GSM()
                : this("BlackBerry", "RIM")
          {
 
          }

          public GSM(string model, string manufacturer)
                : this(model, manufacturer, 0)
          {
 
          }

          public GSM(string model, string manufacturer, decimal price)
                : this(model, manufacturer, price, null)
          {
 
          }

          public GSM(string model, string manufacturer, decimal price, string owner)
                : this(model, manufacturer, price, owner, null)
          {
 
          }

          public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
                : this(model, manufacturer, price, owner, battery, null)
          {
 
          }

          public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
          {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
                this.owner = owner;
                this.battery = battery;
                this.display = display;
                this.callHistory = callHistory;
          }

          public string GSMInfo()
          {
                StringBuilder sb = new StringBuilder();
                sb.Append("Model: " + this.model + "\n");
                sb.Append("Manufacturer: " + this.manufacturer + "\n");
                sb.Append("Price: " + this.price + "\n");
                sb.Append("Owner: " + this.owner + "\n");
                sb.Append("Battery: " + this.battery + "\n");
                sb.Append("Display: " + this.display + "\n");
                return sb.ToString();
          }

          public override string ToString()                                              // Task: 4
          {
                return GSMInfo();
          }

          public void AddCall(Call call)                                                 // Task: 10
          {
                this.callHistory.Add(call);
          }

          public void DeleteCall(Call call)                                              
          {
                this.callHistory.Remove(call);
          }

          public void ClearCallHistory()
          {
                this.callHistory.RemoveRange(0, callHistory.Count);
          }

          public decimal TotalPrice(decimal pricePerMinute = 0.20m)                                   // Task: 11 
          {
                decimal totalPrice = 0;
                for (int call = 0; call < this.callHistory.Count; call++)
                {
                      totalPrice += ((this.callHistory[call].Duration / 60) + 1) * pricePerMinute;
                }
                return totalPrice;
          }

          public string Model
          {
                get { return this.model; }
                set { this.model = value; }
          }

          public string Manufacturer
          {
                get { return this.manufacturer; }
                set { this.manufacturer = value; }
          }

          public decimal Price
          {
                get { return this.price; }
                set { this.price = value; }
          }

          public string Owner
          {
                get { return this.owner; }
                set { this.owner = value; }
          }

          public string IPhone4S
          {
                get { return iPhone4S.ToString(); }                                      // Is that right ?
          }

          public List<Call> CallHistory
          {
                get { return this.callHistory; }
          }
    }

    public class Battery
    {
          private string batteryModel = null;
          private int hoursIdle = 0;
          private int hoursTalk = 0;
          private BatteryType batteryType = new BatteryType();

          public Battery()
                : this("F-S1")
          {
 
          }

          public Battery(string batteryModel)
                : this(batteryModel, 0)
          {
 
          }

          public Battery(string batteryModel, int hoursIdle)
                : this(batteryModel, hoursIdle, 0)
          {
 
          }

          public Battery(string batteryModel, int hoursIdle, int hoursTalk)
          {
                this.batteryModel = batteryModel;
                this.hoursIdle = hoursIdle;
                this.hoursTalk = hoursTalk;
          }

          public string Model
          {
                get { return this.batteryModel; }
                set { this.batteryModel = value; }                             // ???? Is it possible to have two Properties in the same class with a name alike ????
          }

          public int HoursIdle
          {
                get { return this.hoursIdle; }
                set { this.hoursIdle = value; }
          }

          public int HoursTalk
          {
                get { return this.hoursTalk; }
                set { this.hoursTalk = value; }
          }

          public BatteryType BatteryType
          {
                get { return this.batteryType; }
                set { this.batteryType = value; }
          }

    }

    public class Display
    {
          private string size = null;
          private int colors = 0;

          public Display()
                : this("3.2 inch")
          {
 
          }

          public Display(string size)
                : this(size, 0)
          {
 
          }

          public Display(string size, int colors)
          {
                this.size = size;
                this.colors = colors;
          }

          public string Size
          {
                get { return this.size; }
                set { this.size = value; }
          }

          public int Colors
          {
                get { return this.colors; }
                set { this.colors = value; }
          }
    }

    public class Call                                          // Task: 8
    {
          private DateTime date = new DateTime();
          private string dialedNumber = null;
          private int duration = 0;

          public Call(DateTime date, string dialedNumber, int duration)
          {
                this.date = date;
                this.dialedNumber = dialedNumber;
                this.duration = duration;
          }

          public DateTime Date
          {
                get { return this.date; }
                set { this.date = value; }
          }

          public string DialedNumber
          {
                get { return this.dialedNumber; }
                set { this.dialedNumber = value; }
          }

          public int Duration
          {
                get { return this.duration; }
                set { this.duration = value; }
          }
    }
    
    public enum BatteryType                                    // Task: 3
    {
            LiIon, LiPo, NiMH, NiCd
    }
}
