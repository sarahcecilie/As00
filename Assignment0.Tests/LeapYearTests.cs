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

            Assert.Equal(true, output);
        }

        [Fact]

        public void leapYear_is_false_when_divided_by_4()
        {
            var output = false;

            output = LeapYear.isLeapYear(1990);

            Assert.Equal(false, output);
        }

        [Fact]

        public void leapYear_is_false_when_divided_by_100()
        {
            var output = false;

            output = LeapYear.isLeapYear(1900);

            Assert.Equal(false, output);
        }

        [Fact]
      
        public void leapYear_is_true_when_divided_by_400()
        {
            var output = false;

            output = LeapYear.isLeapYear(2000);

            Assert.Equal(true, output);
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

        [Fact]

        public void leapYear_error_message_is_printed_by_wrong_year()
        {
            var input = new StringReader("1500");
            Console.SetIn(input);

            var writer = new StringWriter();
            Console.SetOut(writer);

            LeapYear.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Please enter a year from 1582 and beyond!", output);
        }

        [Fact]
        public void leapYear_error_message_is_printed_by_not_int()
        {
            var input = new StringReader("twothousand");
            Console.SetIn(input);

            var writer = new StringWriter();
            Console.SetOut(writer);

            LeapYear.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Please enter a four digit number!", output);
        }
    }
}
