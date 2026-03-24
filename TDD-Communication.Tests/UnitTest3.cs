using Shouldly;
using TDD.Communications;
using TDD_Communication;

namespace TDD_Communication.Tests;

public class AddAsciiCodesTest
{

    [Test]
    public void AddAsciiCodes_WithSingleChar_ReturnsAsciiValue()
    {
        var calculator = new AddAsciiCodes();
        string input = "a";
        var result = calculator.AddAscii_Codes(input);
        result.ShouldBe(97);
    }
}
