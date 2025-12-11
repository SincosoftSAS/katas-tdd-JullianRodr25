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
        public void Generate_WithThree_ReturnsFizzAtThirdPosition()
        {
            var result = FizzBuzzGenerator.Generate(3);

            result.Should().HaveCount(3);
            result[2].Should().Be("Fizz");
        }
        
        [Fact]
        public void Generate_WithFive_ReturnsBuzzAtFifthPosition()
        {
            var result = FizzBuzzGenerator.Generate(5);

            result.Should().HaveCount(5);
            result[4].Should().Be("Buzz");
        }
        
        [Fact]
        public void Generate_WithSix_ReturnsFizzAtSixthPosition()
        {
            var result = FizzBuzzGenerator.Generate(6);

            result.Should().HaveCount(6);
            result[5].Should().Be("Fizz");
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