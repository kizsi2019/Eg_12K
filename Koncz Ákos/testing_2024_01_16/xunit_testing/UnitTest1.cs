using utilitytest;
using Xunit;
using FluentAssertions;

namespace xunit_testing
{
    public class UnitTest1
    {
        [Fact]
        public void AddTwoNumbers_Returns_Sum_Of_Numbers()
        {
            Calculator calculator = new Calculator();

            var result = calculator.AddTwoNumbers(5, 6);

            Assert.Equal(11, result);
        }

        [Fact]
        public void IsAString_Returns_Input_If_String()
        {
            Calculator calculator = new Calculator();

            var result = calculator.IsAString("Jani");

            Assert.Equal("Jani", result);
        }

        [Fact]
        public void IsAString_Returns_If_Not_Null()
        {
            Calculator calculator = new Calculator();

            var result = calculator.IsAString(null);

            Assert.Equal("It's not a text", result);
        }

        [Fact]
        public void IsAString_Returns_If_Not_String()
        {

            Calculator calculator = new Calculator();

            var result = calculator.IsAString(42);

            Assert.Equal("It's not a text", result);
        }

        [Theory]
        [InlineData("Hello", "Hello")]
        [InlineData(null, "It's not a text")]
        [InlineData(42, "It's not a text")]
        public void IsAString_Returns_Correct_Result(object input, string result)
        {
            Calculator calculator = new Calculator();

            var result1 = calculator.IsAString(input);

            Assert.Equal(result, result1);
        }

        //Ugyanaz csak should be-val

        [Theory]
        [InlineData("Hello", "Hello")]
        [InlineData(null, "It's not a text")]
        [InlineData(42, "It's not a text")]
        public void IsAString_Returns_Correct_Result1(object input, string expectedResult)
        {
            Calculator calculator = new Calculator();

            var result = calculator.IsAString(input);

            result.Should().Be(expectedResult);
        }


    }
}