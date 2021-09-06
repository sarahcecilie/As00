using System;
using Xunit;
using doAssignment0;

namespace Assignment0.Tests
{
    public class LeapYearTests
    {
        [Fact]
        public void leapYear_is_true_4()
        {
            var leapYear = new LeapYear();
            var output = false;

            output = leapYear.isLeapYear(2000);

            Assert.True(output);
        }

        [Fact]
        public void leapYear_is_false_100()
        {
            var leapYear = new LeapYear();
            var output = false;

            output = leapYear.isLeapYear(1900);

            Assert.False(output);
        }

        [Fact]
        public void leapYear_is_true_400()
        {
            var leapYear = new LeapYear();
            var output = false;

            output = leapYear.isLeapYear(1600);

            Assert.True(output);
        }

    }
}
