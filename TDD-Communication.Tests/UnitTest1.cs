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

        [Test]
        public void SumMiddleNumbers_ArrDoubleElements_ReturnZero()
        {
            //Arrange
            var calculator = new Calculator();
            int[] numbers = { 1, 2 };
            //Act

            var result = calculator.SumMiddleNumbers(numbers);
            //Assert
            result.ShouldBe(0);
        }

        [Test]
        public void SumMiddleNumbers_ArrTripleElements_ReturnMiddleValue()
        {
            //Arrange
            var calculator = new Calculator();
            int[] numbers = { 1, 2, 3 };
            //Act

            var result = calculator.SumMiddleNumbers(numbers);
            //Assert
            result.ShouldBe(2);
        }

        [Test]
        public void SumMiddleNumbers_WithMoreNumbers_ReturnAllExceptMinMax()
        {
            var calculator = new Calculator();
            int[] numbers = { 1, 2, 3, 4, 5 };
            var result = calculator.SumMiddleNumbers(numbers);
            result.ShouldBe(9);
        }

    }
}