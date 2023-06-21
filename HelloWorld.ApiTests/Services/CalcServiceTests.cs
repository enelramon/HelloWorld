using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Api.Services.Tests;

[TestClass()]
public class CalcServiceTests
{
    [TestMethod()]
    public void PowTest()
    {
        //Arrange
        var number = 1;
        var expected = 4;
        var calcService = new CalcService(); 

        //Act
        var result = calcService.Pow(number); 

        //Assert
        Assert.AreEqual(expected, result); 
    }
}