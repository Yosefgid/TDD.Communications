using Shouldly;
using TDD.Communications;

namespace TDD_Communication.Tests
{
    public class CalculatorTests
    {
  
        [Test]
        public void SumMiddleNumbers_ArrSingleElement_ReturnZero()
        {
            //Arrange
            var calculator = new Calculator();
            int[] numbers = { 1 };
            //Act
            var result = calculator.SumMiddleNumbers(numbers);
            //Assert
            result.ShouldBe(0);

            //Assert.That(result, Is.EqualTo(0));
        }
    }
}