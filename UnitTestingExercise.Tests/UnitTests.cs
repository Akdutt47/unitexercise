using Xunit;
using System;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(-2, -3, -5, -10)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int actual = calculator.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(100, 50, 50)]
        [InlineData(-5, -3, -2)]
        [InlineData(0, 0, 0)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 5, 0)]
        [InlineData(10, 10, 100)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }





    }
}

