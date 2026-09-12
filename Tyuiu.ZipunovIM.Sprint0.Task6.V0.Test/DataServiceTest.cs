namespace Tyuiu.ZipunovIM.Sprint0.Task6.V0.Test;

using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.ZipunovIM.Sprint0.Task6.V0.Lib;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckAdditionArrayValid()

    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.AdditionArray(numbers);
        Assert.AreEqual(15, res);
    }
    public void CheckSubtractionArrayValid()
    {
        var numders = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.SubtractionArray(numders);
        Assert.AreEqual(15, res);
    }
    public void CheckMultArrayValid()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, };
        var res = DataService.MultiplicationArray (numbers);
        Assert.AreEqual(120, res );


    }
}

