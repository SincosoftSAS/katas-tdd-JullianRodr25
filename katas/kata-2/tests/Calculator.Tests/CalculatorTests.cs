using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int valor1 = 5;
            int valor2 = 3;

            // Act
            int result = _calculator.Add(valor1, valor2);

            // Assert
            result.Should().Be(8);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int valor1 = 10;
            int valor2 = 4;

            // Act
            int result = _calculator.Subtract(valor1, valor2);

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int valor1 = 4;
            int valor2 = 3;

            // Act
            int result = _calculator.Multiply(valor1, valor2);

            // Assert
            result.Should().Be(12);
        }
    }
}