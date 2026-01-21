using BlazorWebApp.Utils;
using Xunit;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test_Add_ReturnsSum()
    {
        var result = MathUtils.Add(2, 3);
        Assert.Equal(5, result);
    }
}