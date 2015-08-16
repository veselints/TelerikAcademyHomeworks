using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    public class Battery
    {
        private string model;
        private TimeSpan hoursIdle;
        private TimeSpan hoursTalk;
        private BatteryType bateryType;

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
                    throw new ArgumentException("The batery model name is too short!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public TimeSpan HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                try
                {
                    this.hoursIdle = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter a valid time in the format HH:mm!");
                }
            }
        }

        public TimeSpan HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                try
                {
                    this.hoursTalk = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter a valid time in the format HH:mm!");
                }
            }
        }

        public BatteryType BateryType
        {
            get
            {
                return this.bateryType;
            }
            set
            {
                this.bateryType = value;
            }
        }

        public Battery(string model, TimeSpan hoursIdle)
            : this(model, hoursIdle, TimeSpan.Zero, BatteryType.NA)
        {
        }

        public Battery(TimeSpan hoursIdle, TimeSpan hoursTalk)
            : this(null, hoursIdle, hoursTalk, BatteryType.NA)
        {
        }

        public Battery(string model)
            : this(model, TimeSpan.Zero, TimeSpan.Zero, BatteryType.NA)
        {
        }

        public Battery(TimeSpan hoursTalk)
            : this(null, TimeSpan.Zero, hoursTalk, BatteryType.NA)
        {
        }

        public Battery()
            : this(null, TimeSpan.Zero, TimeSpan.Zero, BatteryType.NA)
        {
        }

        public Battery(string model, TimeSpan hoursTalk, BatteryType bateryType)
            : this(TimeSpan.Zero)
        {
        }

        public Battery(string model, TimeSpan hoursIdle, TimeSpan hoursTalk, BatteryType bateryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.bateryType = bateryType;
        }

    }
}
