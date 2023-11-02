using BusinessLogic.Providers;

namespace BusinessLogic.DailyPoints;

public class DailyPointsResolver : IDailyPointsResolver
{
    private readonly ISystemClock _systemClock;

    private const int INITIAL_POINTS = 2;

    public DailyPointsResolver(ISystemClock systemClock)
    {
        _systemClock = systemClock;
    }

    public long GetDailyPoints()
    {
        DateTime seasonStart = new(DateTime.Now.Year, GetSeasonStartMonth(_systemClock.UtcNow.Date.Month), 1);

        int currentTimeOfYearDay = (_systemClock.UtcNow - seasonStart).Days;

        if (currentTimeOfYearDay == 0)
        {
            return INITIAL_POINTS;
        }

        if (currentTimeOfYearDay == 1)
        {
            return INITIAL_POINTS + 1;
        }

        int dayBeforePreviousDay = INITIAL_POINTS;
        int previusDayPoints = INITIAL_POINTS + 1;

        for (int day = 2; day <= currentTimeOfYearDay; day++)
        {
            int pointsGainedThisDay = dayBeforePreviousDay + (int)Math.Round(previusDayPoints * 0.6, 0);

            dayBeforePreviousDay = previusDayPoints;
            previusDayPoints = pointsGainedThisDay;
        }

        return previusDayPoints;
    }

    private static int GetSeasonStartMonth(int currentMonth)
    {
        return currentMonth switch
        {
            9 or 10 or 11 => 9, //Fall (September)

            12 or 1 or 2 => 12, // Winter (December)

            3 or 4 or 5 => 3, // Spring (Marth)

            6 or 7 or 8 => 6, // Summer (June)

            _ => throw new InvalidOperationException($"{currentMonth} is not a month")
        };
    }
}