using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialledPhoneN;
        private TimeSpan duration;

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                try
                {
                    this.dateAndTime = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter a valid date and time in the format YYYY.MM.DD HH:mm!");
                }

            }
        }

        public string DialledPhoneN
        {
            get
            {
                return this.dialledPhoneN;
            }
            set
            {
                this.dialledPhoneN = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                try
                {
                    this.duration = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter a valid time in the format HH:mm!");
                }
            }
        }

        public Call(DateTime dateAndTime, string dialledPhoneN, TimeSpan duration)
            : base()
        {
            this.dateAndTime = dateAndTime;
            this.dialledPhoneN = dialledPhoneN;
            this.duration = duration;
        }
    }
}
