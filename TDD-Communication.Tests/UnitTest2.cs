using Shouldly;
using TDD.Communications;

namespace TDD_Communication.Tests;

public class CalculateMeanTest
{
    [Test]
    public void CalculateMean_ArrSingleElement_ReturnSameNumber()
    {
        var calculator = new Calculate_Mean();
        int[] num = { 2 };
        var result = calculator.CalculateMean(num);
        result.ShouldBe(2);
    }
}
