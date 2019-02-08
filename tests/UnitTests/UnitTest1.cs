using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
       public void Income_Tax_Calculation_Single()
        {
            var expected = 1900;
            var total_income = 2000;
            var deductions = 100;
            var actual = Tax_Calculation(total_income,deductions);
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        public void IsEven_WorksWithManyInputs(int value)
        {
            Assert.True(IsEven(value));
        }



        double Tax_Calculation(int total_income,int deductions)
        {
            return total_income - deductions;
        }
        bool IsEven(int value)
        {
            return value % 2 == 0;
        }

    }
}
