using Shouldly;
using System;
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

    [Test] 
    public void CalculateMean_ArrDoubleElement_ReturnsMean()
    {
        var calculator=new Calculate_Mean();
        int[] num = { 2, 3 };
        var result = calculator.CalculateMean(num);
        result.ShouldBe(2.5);
    }

    [Test]
    public void CalculateMean_ArrMultipleElemnt_ReturnMean()
    {
        var calculator = new Calculate_Mean();
       int[] num ={2, 2, 1, 8, 3, 2, 4 };
    var result = calculator.CalculateMean(num);
        result.ShouldBe(3.14);

    }


}
