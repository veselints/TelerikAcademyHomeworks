namespace Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DIgitToEnglishNumber(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "flotingPoint");
            PrintAsNumber(0.75, "percentage");
            PrintAsNumber(2.30, "rightIntend");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + CheckIfPointsAreAligned(-1, 2.5));
            Console.WriteLine("Vertical? " + CheckIfPointsAreAligned(3, 3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
        
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (!(ValidateSideInput(a) && ValidateSideInput(b) && ValidateSideInput(c)))
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        static string DIgitToEnglishNumber(int number)
        {
            switch (number)
            {
                case 0: 
                    return "zero";
                case 1: 
                    return "one";
                case 2: 
                    return "two";
                case 3:
                    return "three";
                case 4: 
                    return "four";
                case 5: 
                    return "five";
                case 6: 
                    return "six";
                case 7: 
                    return "seven";
                case 8:
                    return "eight";
                case 9: 
                    return "nine";
                default:
                    return "Invalid number!";
            }
        }

        static int FindMax(params int[] elements)
        {
            if (!ValidateNumbersInput(elements))
            {
                throw new ArgumentOutOfRangeException("You have given an invalid array of numbers.");                
            }

            if (elements.Length == 1)
            {
                return elements[0];
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (format == "flotingPoint")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "percentage")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "rightIntend")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                Console.WriteLine("You have given invalid format input.");                
            }
        }


        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool CheckIfPointsAreAligned(double point1, double point2)
        {
            if (point1 == point2)
            {
                return true;
            }

            return false;
        }

        private static bool ValidateSideInput(double side)
        {
            if (side <= 0)
            {
                return false;
            }

            return true;
        }

        private static bool ValidateNumbersInput(int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
