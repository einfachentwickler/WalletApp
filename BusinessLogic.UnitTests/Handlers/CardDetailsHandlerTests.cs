using BusinessLogic.Constants;
using BusinessLogic.DailyPoints;
using BusinessLogic.DTO;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Handlers.CardDetails;
using BusinessLogic.Providers;
using BusinessLogic.RandomNumberGenerator;
using NSubstitute;
using NUnit.Framework;

namespace BusinessLogic.UnitTests.Handlers;

[TestFixture]
public class CardDetailsHandlerTests
{
    private ICardDetailsHandler _instance;

    private ISystemClock _systemClock;

    private IDailyPointsResolver _dailyPointsResolver;

    private IBalanceGenerator _generator;

    private IDailyPointsFormatter _formatter;

    [SetUp]
    public void Setup()
    {
        _systemClock = Substitute.For<ISystemClock>();

        _dailyPointsResolver = Substitute.For<IDailyPointsResolver>();

        _generator = Substitute.For<IBalanceGenerator>();

        _formatter = Substitute.For<IDailyPointsFormatter>();

        _instance = new CardDetailsHandler(_systemClock, _dailyPointsResolver, _generator, _formatter);
    }

    [Test]
    public void Handle_Success_ReturnsModels()
    {
        //Arrange
        _generator.Balance.Returns(123);

        _systemClock.UtcNow.Returns(DateTime.Parse("2023-12-12"));

        _dailyPointsResolver.GetDailyPoints().Returns(12000);
        _formatter.Format(12000).Returns("12k");

        //Act
        CardDetailsModel actualResult = _instance.GetAsync();

        //Assert
        Assert.That(actualResult.Available, Is.EqualTo(BusinessLogicConstants.MAX_CARD_LIMIT - 123));
        Assert.That(actualResult.DailyPoints, Is.EqualTo("12k"));
        Assert.That(actualResult.Balance, Is.EqualTo(123));
    }
}