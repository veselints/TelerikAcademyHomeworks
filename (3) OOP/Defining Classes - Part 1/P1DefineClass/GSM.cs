using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private static decimal callPricePerSecond = 0.00616667m;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The model name is too short!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The manufacturer name is too short!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("The price should have positive value!");
                    }
                    else
                    {
                        this.price = value;
                    }
                }
                catch (Exception)
                {

                    throw new ArgumentException("You shuold enter a positive number as a price of the GSM!");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The owner name is too short!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Batery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        
        public GSM(string model, string manufacturer)
            : base()
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer)
        {
            this.price = price;
        }
        
        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }

        public void DisplayGSMInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format(FormatCharacteristic("Manufacturer", this.manufacturer) +
                                FormatCharacteristic("Model", this.model) +
                                FormatCharacteristic("Price", String.Format("{0:C2}", this.price)) +
                                FormatCharacteristic("Owner", this.owner) +
                                FormatCharacteristic("Batery model", this.battery.Model) +
                                FormatCharacteristic("Batery hoursIdle", String.Format("{0}", this.battery.HoursIdle)) +
                                FormatCharacteristic("Batery hoursTalk", String.Format("{0}", this.battery.HoursTalk)) +
                                FormatCharacteristic("Batery type", String.Format("{0}", this.battery.BateryType)) +
                                FormatCharacteristic("Display size", String.Format("{0} x {1} px", this.display.Size[0], this.display.Size[1])) +
                                FormatCharacteristic("N display colours", String.Format("{0}", this.display.NumberOfColours)));
        }

        private string FormatCharacteristic(string lable, string characteristic)
        {
            return lable.PadRight(18) + "-> " + characteristic + "\r\n";
        }

        public static GSM IPhone4S = new GSM("IPhone4S", "Apple", "Evstati", 1040.50, new Battery("RP-H-45", new TimeSpan(1, 02, 0, 0), BatteryType.NiMH), new Display(65000));

        public static decimal CalculateCallsPrice(GSM thisGSM)
        {
            decimal result = 0;
            foreach (var call in thisGSM.callHistory)
            {
                result += Convert.ToDecimal(call.Duration.TotalSeconds) * callPricePerSecond;
            }
            return result;
        }

        public void DisplayCallsInfo()
        {
            int callsCounter = 1;
            foreach (var call in this.CallHistory)
            {
                Console.WriteLine(callsCounter);
                Console.WriteLine(call.DateAndTime.Date.ToString("dd.MM.yyyy"));
                Console.WriteLine(call.DateAndTime.TimeOfDay);
                Console.WriteLine(call.Duration);
                Console.WriteLine(call.DialledPhoneN);
                Console.WriteLine();
                callsCounter++;
            }
            }

    }
}
