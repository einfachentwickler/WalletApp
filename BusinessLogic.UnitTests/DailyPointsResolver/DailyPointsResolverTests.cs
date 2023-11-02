using BusinessLogic.DailyPoints;
using BusinessLogic.Providers;
using NSubstitute;
using NUnit.Framework;

namespace BusinessLogic.UnitTests.DailyPoints;

[TestFixture]
public class DailyPointsResolverTests
{
    private IDailyPointsResolver _instance;

    private ISystemClock _clock;

    [SetUp]
    public void Setup()
    {
        _clock = Substitute.For<ISystemClock>();

        _instance = new DailyPointsResolver(_clock);
    }

    [TestCase("2023-09-01", 2)]
    [TestCase("2023-09-02", 3)]

    [TestCase("2023-12-01", 2)]
    [TestCase("2023-12-02", 3)]

    [TestCase("2023-03-01", 2)]
    [TestCase("2023-03-02", 3)]

    [TestCase("2023-06-01", 2)]
    [TestCase("2023-06-02", 3)]

    [TestCase("2023-09-03", 4)]
    [TestCase("2023-09-04", 5)]
    [TestCase("2023-09-05", 7)]
    [TestCase("2023-09-06", 9)]
    [TestCase("2023-09-07", 12)]

    [TestCase("2023-12-03", 4)]
    [TestCase("2023-12-04", 5)]
    [TestCase("2023-12-05", 7)]
    [TestCase("2023-12-06", 9)]
    [TestCase("2023-12-07", 12)]

    [TestCase("2023-03-03", 4)]
    [TestCase("2023-03-04", 5)]
    [TestCase("2023-03-05", 7)]
    [TestCase("2023-03-06", 9)]
    [TestCase("2023-03-07", 12)]

    [TestCase("2023-06-03", 4)]
    [TestCase("2023-06-04", 5)]
    [TestCase("2023-06-05", 7)]
    [TestCase("2023-06-06", 9)]
    [TestCase("2023-06-07", 12)]
    public void GetDailyPoints_DifferentSeasons_ReturnsPoints(string dateNow, int expectedResult)
    {
        //Arrange
        _clock.UtcNow.Returns(DateTime.Parse(dateNow));

        //Act
        long actualResult = _instance.GetDailyPoints();

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}