namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
                return true;
            throw new NotImplementedException("Implement using TDD: Red → Green → Refactor");
        }
    }
}