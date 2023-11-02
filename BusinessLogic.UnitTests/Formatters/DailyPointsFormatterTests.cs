using BusinessLogic.Formatters;
using BusinessLogic.Formatters.Interfaces;
using NUnit.Framework;

namespace BusinessLogic.UnitTests.Formatters;

[TestFixture]
public class DailyPointsFormatterTests
{
    private IDailyPointsFormatter _instance;

    [SetUp]
    public void Setup()
    {
        _instance = new DailyPointsFormatter();
    }

    [TestCase(12000)]
    [TestCase(12)]
    public void Format_Success_ReturnsFormatterValue(long points)
    {
        //Act
        string actualResult = _instance.Format(points);

        //Assert
        Assert.That(actualResult, Is.EqualTo(points == 12000 ? "12k" : "12"));
    }
}