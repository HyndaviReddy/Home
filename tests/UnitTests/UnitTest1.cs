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
 
 

       double Tax_Calculation(int total_income,int deductions)
        {
            return total_income - deductions;
        }
       
    }
}
