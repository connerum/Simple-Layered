global using Xunit;
using Xunit;
namespace BusinessLogic.Tests;

public class FactorialServiceTest
{
    [Fact]
    public void FactorialTest_Positive()
    {
        Assert.Equal(24, FactorialService.CalculateFactorial(4));
    }
    [Fact]
    public void FactorialTest_Negative()
    {
        Assert.Throws<Exception>(()=>{
            FactorialService.CalculateFactorial(-4);
        });
    }

    [Fact]
    public void FactorialTest_Zero()
    {
        Assert.Equal(1, FactorialService.CalculateFactorial(0));
    }
}