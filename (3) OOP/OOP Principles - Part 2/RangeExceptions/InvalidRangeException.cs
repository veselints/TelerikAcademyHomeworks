using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T rangeStart;
        private T rangeEnd;

        public InvalidRangeException(T start, T end)
            : this(string.Empty, null, start, end)
        {
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, null, start, end)
        {
        }

        public InvalidRangeException(string message, Exception innerException, T start, T end)
            : base(message, innerException)
        {
            this.RangeStart = start;
            this.RangeEnd = end;
        }
        
        public T RangeStart
        {
            get { return this.rangeStart; }
            private set
            {
                try
                {
                    this.rangeStart = value;
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.Message);
                } 
            }
        }

        public T RangeEnd
        {
            get { return this.rangeEnd; }
            private set
            {
                try
                {
                    this.rangeEnd = value;
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
        }

        public override string Message
        {
            get
            {
                return string.Format("Invalid range. Parameters must be in the range: [{0} - {1}].", this.RangeStart, this.RangeEnd);
            }
        }
    }
}
