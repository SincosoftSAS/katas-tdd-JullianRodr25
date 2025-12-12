using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-3, -9, -12)]
        public void Add_WithPositiveAndNegativeNumbers_ReturnsSum(int valor1,int valor2, int valorEsperado)
        {
            // Act
            int result = _calculator.Add(valor1, valor2);

            // Assert
            result.Should().Be(valorEsperado);
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

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsQuotient()
        {
            // Arrange
            int valor1 = 10;
            int valor2 = 2;

            // Act
            int result = _calculator.Divide(valor1, valor2);

            // Assert
            result.Should().Be(5);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act
            Action act = () => _calculator.Divide(a, b);

            // Assert
            act.Should().Throw<DivideByZeroException>().WithMessage("Cannot divide by zero.");
        }
    }
}