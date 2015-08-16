namespace Methods
{
    using System;
    using System.Globalization;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            string firstDateAsAString = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            string secondDateAsAString = other.OtherInfo.Substring(other.OtherInfo.Length - 10);

            string dateTimeFormat = "dd.MM.yyyy";

            DateTime firstDate = DateTime.ParseExact(firstDateAsAString, dateTimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.AdjustToUniversal);
            DateTime secondDate = DateTime.ParseExact(secondDateAsAString, dateTimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.AdjustToUniversal);
            
            return firstDate < secondDate;
        }
    }
}