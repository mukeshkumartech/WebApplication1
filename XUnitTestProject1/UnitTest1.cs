using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {        
        [Fact]
        public void Task_Add_TwoNumber()
        {
            // Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 6;

            // Act
            var sum = num1 + num2;

            //Assert
            Assert.Equal(expectedValue, sum);
        }
    }
}
