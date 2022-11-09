namespace UnitTesting.Tests
{
    // Add Project reference
    public class CalculatorTests
    {

        // Fact
        [Fact]
        public void Add_CalculateSimpleValues()
        {
            // Arrange
            double expected = 5;

            // Act
            var calc = new Calculator();
            double actual = calc.Add(3,2);

            // Assert
            Assert.True(actual == expected);
        }

        // Theory
        [Theory]
        [InlineData(4,8, 12)]
        [InlineData(-4,8, 4)]
        [InlineData(4.32,2.13, 6.45)]
        [InlineData(Double.MaxValue, 8, Double.MaxValue)]   // Here we testing an edge case
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            var calc = new Calculator();
            double actual = calc.Add(x, y);

            // Assert
            Assert.True(actual == expected);
        }

        // Fact - Fact is better for breaking behaviour
        [Fact]
        public void Devide_DevisionByZeroShouldThrow()
        {
            // Arrange

            // Act
            var calc = new Calculator();

            // Assert
            Assert.Throws<DivideByZeroException>(() => { calc.Devide(3, 0); }); // WE put the Call/Act inside the Action's body
        }

        // Fact
        // Theory
        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(4.8, 2, 2.4)]
        public void Devide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            var calc = new Calculator();
            double actual = calc.Devide(x, y);

            // Assert
            Assert.True(actual == expected);
        }
    }
}