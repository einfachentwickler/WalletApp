using BusinessLogic.Constants;
using BusinessLogic.DailyPoints;
using BusinessLogic.DTO;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Providers;
using BusinessLogic.RandomNumberGenerator;
using System.Globalization;

namespace BusinessLogic.Handlers.CardDetails;

public class CardDetailsHandler : ICardDetailsHandler
{
    private readonly ISystemClock _systemClock;

    private readonly IDailyPointsResolver _resolver;

    private readonly IBalanceGenerator _generator;

    private readonly IDailyPointsFormatter _formatter;

    public CardDetailsHandler(ISystemClock systemClock, IDailyPointsResolver resolver, IBalanceGenerator generator, IDailyPointsFormatter formatter)
    {
        _systemClock = systemClock;
        _resolver = resolver;
        _generator = generator;
        _formatter = formatter;
    }

    public CardDetailsModel GetAsync()
    {
        double balance = _generator.Balance;

        long dailyPoints = _resolver.GetDailyPoints();

        return new CardDetailsModel
        {
            Balance = Math.Round(balance, 2),
            Available = Math.Round(BusinessLogicConstants.MAX_CARD_LIMIT - balance, 2),
            NoPaymentDue = $"You’ve paid your {CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(_systemClock.UtcNow.Month)} balance.",
            DailyPoints = _formatter.Format(dailyPoints),
        };
    }
}