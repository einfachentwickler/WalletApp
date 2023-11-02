using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Providers;
using System.Globalization;

namespace BusinessLogic.Formatters;

public class DateFormatter : IDateFormatter
{
    private readonly ISystemClock _systemClock;

    public DateFormatter(ISystemClock systemClock)
    {
        _systemClock = systemClock;
    }

    public string Format(DateTime date)
    {
        Calendar calendar = DateTimeFormatInfo.GetInstance(CultureInfo.InvariantCulture).Calendar;

        DateTime d1 = date.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(date));

        DateTime d2 = _systemClock.UtcNow.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(_systemClock.UtcNow.Date));

        if(date.Date == _systemClock.UtcNow.Date)
        {
            return "Today";
        }

        if (date.Date == _systemClock.UtcNow.Date.AddDays(1))
        {
            return "Yesterday";
        }

        return d1 == d2 ? date.ToString("dddd", CultureInfo.InvariantCulture) : date.ToString("d", CultureInfo.InvariantCulture);
    }
}