using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Theory]
        [InlineData(2008)]
        [InlineData(2004)]
        [InlineData(2012)]  
        public void Year_DivisibleBy4_ButNotBy100_IsLeapYear(int year)
        {
            // Ejemplo: 2004 es año bisiesto
            Assert.True(LeapYearChecker.IsLeapYear(year));
        }
        
        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void Year_NotDivisibleBy4_IsNotLeapYear(int year)
        {
            // Ejemplo: 2001 no es año bisiestoo
            Assert.False(LeapYearChecker.IsLeapYear(year));
        }
        
        [Fact]
        public void Year_DivisibleBy100_ButNotBy400_IsNotLeapYear()
        {
            // Ejemplo: 1900 no es año bisiesto
            Assert.False(LeapYearChecker.IsLeapYear(1900));
        }
    }
}
