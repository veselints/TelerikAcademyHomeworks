using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to3StudentClass.StudentProperties
{
    class Contacts
    {

        // permanent address, mobile phone e-mail

        private string address;
        private string mobilePhone;
        private string eMail;

        public Contacts(string address, string phone, string eMail)
        {
            this.Addresss = address;
            this.MobilePhone = phone;
            this.EMail = eMail;
        }

        public string Addresss
        {
            get { return address; }
            private set 
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The adress is too short!");
                }
                else
                {
                    address = value;
                }
            }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            private set
            {
                if (value.Length < 9)
                {
                    throw new ArgumentException("The phone number is too short!");
                }
                else
                {
                    mobilePhone = value;
                }
            }
        }

        public string EMail
        {
            get { return eMail; }
            private set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The e-mail is too short!");
                }
                else
                {
                    eMail = value;
                }
            }
        }

        public override string ToString()
        {
            string contactsToString = String.Format("{0}, {1}, {2}", this.Addresss, this.MobilePhone, this.EMail);
            return contactsToString;
        }
    }
}
