using BusinessLogic.Formatters;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Providers;
using NSubstitute;
using NUnit.Framework;

namespace BusinessLogic.UnitTests.Formatters;

[TestFixture]
public class DateFormatterTests
{
    private IDateFormatter _instance;

    private ISystemClock clock;

    [SetUp]
    public void Setup()
    {
        clock = Substitute.For<ISystemClock>();

        _instance = new DateFormatter(clock);
    }

    [TestCase("2023-12-10", "2023-12-12", "Tuesday")] //Sunday - Tuesday
    [TestCase("2023-12-17", "2023-12-12", "12/12/2023")] //Sunday - Sunday
    [TestCase("2023-12-17", "2023-12-23", "Saturday")] //Sunday - Saturday
    [TestCase("2023-12-23", "2023-12-23", "Today")]
    [TestCase("2023-12-22", "2023-12-23", "Yesterday")]
    public void Format_CurrentWeek_ReturnDayAsString(string mockedNow, string transactionTime, string expectedResult)
    {
        //Arrange
        clock.UtcNow.Returns(DateTime.Parse(mockedNow));

        //Act
        string actualResult = _instance.Format(DateTime.Parse(transactionTime));

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}