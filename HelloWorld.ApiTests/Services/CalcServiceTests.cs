using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Api.Services.Tests;

[TestClass()]
public class CalcServiceTests
{
    [TestMethod()]
    public void PowTest()
    {
        //Arrange
        var number = 2;
        var expected = 4;
        var calcService = new CalcService();

        //Act
        var result = calcService.Pow(number);

        //Assert
        Assert.AreEqual(expected, result);
    }
}