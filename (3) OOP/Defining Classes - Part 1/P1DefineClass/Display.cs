using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    public class Display
    {
        private int[] size = new int[2];
        private int numberOfColours;

        public int[] Size
        {
            get
            {
                return this.size;
            }
            set
            {
                try
                {
                    if (value[0] <= 0 && value[1] <= 0)
                    {
                        throw new ArgumentException("The height and width of the display should be grater than 0 px!");
                    }
                    else
                    {
                        this.size = value;
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter positive intiger numbers as height and width of the display!");
                }
            }
        }

        public int NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("The number of colours should be more than 0!");
                    }
                    else
                    {
                        this.numberOfColours = value;
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException("You shuold enter a positive integer number as a number of colours!");
                }
            }
        }

        public Display(int[] size, int numberOfColours)
        {
            this.size[0] = size[0];
            this.size[1] = size[1];
            this.numberOfColours = numberOfColours;
        }

        public Display(int[] size)
        {
            this.size[0] = size[0];
            this.size[1] = size[1];
        }

        public Display()
        {
        }

        public Display(int numberOfColours)
        {
            this.numberOfColours = numberOfColours;
        }
    }
}
