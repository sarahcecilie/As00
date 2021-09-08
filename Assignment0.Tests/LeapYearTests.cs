using System;
using System.IO;
using Xunit;
using doAssignment0;

namespace Assignment0.Tests
{
    public class LeapYearTests
    {
        [Fact]

        public void leapYear_is_true_when_divided_by_4()
        {
            var output = false;

            output = LeapYear.isLeapYear(1992);

            Assert.True(output);
        }

        [Fact]

        public void leapYear_is_false_when_divided_by_100()
        {
            var output = false;

            output = LeapYear.isLeapYear(1900);

            Assert.False(output);
        }

        [Fact]
      
        public void leapYear_is_true_when_divided_by_400()
        {
            var output = false;

            output = LeapYear.isLeapYear(2000);

            Assert.True(output);
        }

        [Fact]

        public void leapYear_prints_yay()
        {
            var input = new StringReader("1600");
            Console.SetIn(input);

            var writer = new StringWriter();
            Console.SetOut(writer);

            LeapYear.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);

        }

        [Fact]
        public void leapYear_prints_nay()
        {
            var input = new StringReader("1800");
            Console.SetIn(input);

            var writer = new StringWriter();
            Console.SetOut(writer);

            LeapYear.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }
    }
}
