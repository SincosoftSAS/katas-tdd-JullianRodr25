using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWith1And2()
        {
            var result = FizzBuzzGenerator.Generate(2);

            result.Should().HaveCount(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }

        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }
    }
}